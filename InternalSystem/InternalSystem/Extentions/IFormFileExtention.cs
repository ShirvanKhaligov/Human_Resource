using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Extentions
{
    public static class IFormFileExtention
    {
        //Image
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains(@"image/");
        }
        public static bool ImageSize(this IFormFile file, int maxsize)
        {
            return file.Length / 1024 / 1024 < maxsize;
        }
        public async static Task<string> CopyImage(this IFormFile file, string root, string folder)
        {
            string imgpath = Path.Combine(root, "allUserImg");
            string filename = Path.Combine(folder, Guid.NewGuid().ToString() + file.FileName);
            string ResultPath = Path.Combine(imgpath, filename);
            using (FileStream fileStream = new FileStream(ResultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            string Replaceslahsfilenmae = filename.Replace(@"\", "/");
            return Replaceslahsfilenmae;
        }
        static IFormFile filee { get; set; }
        public async static Task<string> CopyImage2(this string root, string folder)
        {
            
            string imgpath = Path.Combine(root, "allUserImg");
            string filename = Path.Combine(folder, Guid.NewGuid().ToString());
            string ResultPath = Path.Combine(imgpath, filename);
            using (FileStream fileStream = new FileStream(ResultPath, FileMode.Create))
            {
                await filee.CopyToAsync(fileStream);
            }
            string Replaceslahsfilenmae = filename.Replace(@"\", "/");
            return Replaceslahsfilenmae;
        }

        //Word
        public static bool IsWord(this IFormFile file)
        {
            return file.ContentType == "application/msword" ||
                   file.ContentType == "application/octet-stream" ||
                   file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
                   file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.template" ||
                   file.ContentType == "application/vnd.ms-word.document.macroEnabled.12" ||
                   file.ContentType == "application/vnd.ms-word.template.macroEnabled.12" ||
                   file.ContentType == "application/vnd.ms-excel" ||
                   file.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        }
        public static bool WordSize(this IFormFile file, int maxsize)
        {
            return file.Length / 1024 / 1024 < maxsize;
        }
        public async static Task<string> CopyWord(this IFormFile file, string root, string folder)
        {
            string imgpath = Path.Combine(root, "allUserImg");
            string filename = Path.Combine(folder, Guid.NewGuid().ToString() + file.FileName);
            string ResultPath = Path.Combine(imgpath, filename);
            using (FileStream fileStream = new FileStream(ResultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            string Replaceslahsfilenmae = filename.Replace(@"\", "/");
            return Replaceslahsfilenmae;
        }

        //Pdf
        public static bool IsPdf(this IFormFile file)
        {
            return file.ContentType == "application/pdf" ||
                   file.ContentType == "application/x-pdf";
        }
        public static bool PdfSize(this IFormFile file, int maxsize)
        {
            return file.Length / 1024 / 1024 < maxsize;
        }
        public async static Task<string> CopyPdf(this IFormFile file, string root, string folder)
        {
            string imgpath = Path.Combine(root, "allUserImg");
            string filename = Path.Combine(folder, Guid.NewGuid().ToString() + file.FileName);
            string ResultPath = Path.Combine(imgpath, filename);
            using (FileStream fileStream = new FileStream(ResultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            string Replaceslahsfilenmae = filename.Replace(@"\", "/");
            return Replaceslahsfilenmae;
        }
        //public abstract class GetOne
        //{
        //    public int Id { get; set; }
        //    public string RouteID { get; set; }
        //    private readonly InternalSysDBContext _contex;
        //    //public GetOne(InternalSysDBContext context)
        //    //{
        //    //    _contex=context
        //    //}
        //}
    }
}
