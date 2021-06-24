using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class CompanyController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly IHostingEnvironment _env;
        public CompanyController(IHostingEnvironment env, InternalSysDBContext context)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            CompanyVM companyVM = new CompanyVM()
            {
                Companies = _context.Companies.Where(w => w.status != false).Take(5),
                //Company=_context
            };
            return View(companyVM);
        }
        public IActionResult AllCompanies()
        {
            CompanyVM companyVM = new CompanyVM()
            {
                Companies = _context.Companies.Where(w => w.status != false).ToList(),
            };
            return View(companyVM);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CompanyVM companyVM = new CompanyVM()
            {
                Countries = _context.Countries.Where(w => w.Status != false).OrderBy(w => w.Name).ToList()
            };
            return View(companyVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Companies newCompany, IFormFile Image)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid &&
                ModelState["Address"].ValidationState != ModelValidationState.Invalid &&
                ModelState["TaxId"].ValidationState != ModelValidationState.Invalid && Image != null)
            {
                if (newCompany.CityId != 0)
                {
                    //Image check
                    if (!Image.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Şəkil faylı seçin");
                        CompanyVM companyVM = new CompanyVM()
                        {
                            Countries = _context.Countries.Where(w => w.Status != false).OrderBy(w => w.Name).ToList(),
                            Company = newCompany,
                        };
                        return View(companyVM);
                    }
                    if (!Image.ImageSize(2))
                    {
                        ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                        CompanyVM companyVM = new CompanyVM()
                        {
                            Countries = _context.Countries.Where(w => w.Status != false).OrderBy(w => w.Name).ToList(),
                            Company = newCompany,
                        };
                        return View(companyVM);
                    }

                    newCompany.status = true;
                    string filename = await Image.CopyImage(_env.WebRootPath, "company");
                    newCompany.Image = filename;
                    await _context.AddAsync(newCompany);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["SelectCityOrCountry"] = "Zəhmət olmasa şəhər seçin!!";
                    CompanyVM companyVM = new CompanyVM()
                    {
                        Countries = _context.Countries.Where(w => w.Status != false).OrderBy(w => w.Name).ToList(),
                        Company = newCompany,
                    };
                    return View(companyVM);
                }
            }
            else
            {
                CompanyVM companyVM = new CompanyVM()
                {
                    Countries = _context.Countries.Where(w => w.Status != false).OrderBy(w => w.Name).ToList(),
                    Company = newCompany,
                };
                ViewData["nonSelectedImage"] = "Zəhmət olmasa şəkil seçin!!";
                return View(companyVM);
            }

        }
        [HttpGet]
        public IActionResult GetCities(int countryId)
        {
            if (countryId == 0) { return NotFound(); }
            CompanyVM companyVM = new CompanyVM()
            {
                Cities = _context.Cities.Where(w => w.status != false && w.CountriesId == countryId).OrderBy(w => w.Name).ToList(),
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_CitiesSelectListPartial.cshtml", companyVM);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCompany(int ConpanyId)
        {
            if (ConpanyId == 0)
                NotFound();
            Companies findCompany = await _context.Companies.FindAsync(ConpanyId);
            findCompany.status = false;
            _context.Entry(findCompany).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            CompanyVM companyVM = new CompanyVM()
            {
                Companies = _context.Companies.Where(w => w.status != false).ToList(),
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_AllCompaniesPartial.cshtml", companyVM);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            if (Id == 0) { return NotFound(); }
            Companies findCompany = await _context.Companies.FindAsync(Id);
            if (findCompany == null)
                NotFound();
            ViewData["selectedCity"] = findCompany.CityId;
            ViewData["selectedCountry"] = findCompany.City.CountriesId;
            CompanyVM companyVM = new CompanyVM()
            {
                Company = findCompany,
                Cities = _context.Cities.Where(w => w.status != false && w.CountriesId == findCompany.City.CountriesId).ToList(),
                Countries = _context.Countries.Where(w => w.Status != false).ToList(),
            };
            return View(companyVM);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Companies updatedCompany, int Id)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid &&
                ModelState["Address"].ValidationState != ModelValidationState.Invalid &&
                ModelState["TaxId"].ValidationState != ModelValidationState.Invalid)
            {
                if (Id == 0)
                    NotFound();
                Companies findCompany = await _context.Companies.FindAsync(Id);
                if (findCompany == null)
                    NotFound();
                findCompany.Name = updatedCompany.Name;
                findCompany.TaxId = updatedCompany.TaxId;
                findCompany.RegistrationNumber = updatedCompany.RegistrationNumber;
                findCompany.ZipCode = updatedCompany.ZipCode;
                findCompany.Website = updatedCompany.Website;
                findCompany.CityId = updatedCompany.CityId;
                findCompany.Address = updatedCompany.Address;
                _context.Entry(findCompany).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AllCompanies));

            }
            else
            {
                Companies findCompany = await _context.Companies.FindAsync(Id);
                ViewData["selectedCity"] = findCompany.CityId;
                ViewData["selectedCountry"] = findCompany.City.CountriesId;
                CompanyVM companyVM = new CompanyVM()
                {
                    Company = findCompany,
                    Cities = _context.Cities.Where(w => w.status != false && w.CountriesId == findCompany.City.CountriesId).ToList(),
                    Countries = _context.Countries.Where(w => w.Status != false).ToList(),
                };
                return View(companyVM);
            }
        }
    }
}
