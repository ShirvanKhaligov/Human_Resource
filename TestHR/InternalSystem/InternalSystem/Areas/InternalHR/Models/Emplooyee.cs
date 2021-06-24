using InternalSystem.Areas.Employee.Models.FreeVacation;
using InternalSystem.Areas.Employee.Models.Vacation;
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.ComputerSk;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Devices;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using InternalSystem.Areas.InternalHR.Models.Month;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using InternalSystem.Areas.InternalHR.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InternalSystem.Areas.InternalHR.Models
{
    public class Emplooyee
    {
        public Emplooyee()
        {
            LastWorkPlaces = new HashSet<LastWorkPlace>();
            EducationsToEmployees = new HashSet<EducationsToEmployee>();
            PhoneNumberToEmployees = new HashSet<PhoneNumberToEmployee>();
            CommandsToEmployees = new HashSet<CommandsToEmployee>();
            DeviceToEmployees = new HashSet<DeviceToEmployee>();
            RelationToEmployees = new HashSet<RelationToEmployee>();
            LangugaeToEmployees = new HashSet<LanguageToEmployee>();
            PermissionToEmployeees = new HashSet<PermissionToEmployeee>();
            AdditionalInfos = new HashSet<AdditionalInfos>();
            ComputerToEmployees = new HashSet<ComputerToEmployee>();
            DepartmentToCompanies = new HashSet<DepartmentToCompany>();
            Schools = new HashSet<School>();
            TaxBreakToEmplooyees = new HashSet<TaxBreakToEmplooyee>();
            TaxBreakToEmplooyees = new HashSet<TaxBreakToEmplooyee>();

            ScanPdfCommands = new HashSet<ScanPdfCommands>();
            HistoryPositionChanges = new HashSet<HistoryPositionChange>();

            //TaxBreakToEmplooyees = new HashSet<TaxBreakToEmplooyee>();
            TelMes = new HashSet<TelMe>();
            MessageForEmployees = new HashSet<MessageForEmployee>();
            AllCommandsHistories = new HashSet<AllCommandsHistory>();
            WorkDateToEmployees = new HashSet<WorkDateToEmployee>();
            Vacations = new HashSet<Vacation>();
            BusinessTripEmps = new HashSet<BusinessTripEmp>();
            FreeVacations = new HashSet<FreeVacation>();

            //DepBossPositions = new HashSet<DepBossPosition>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa adı daxil edin"), MaxLength(50, ErrorMessage = "Ad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "Ad 2 hərfdən az ola bilməz!")]
        //[NotMapped]
        //public string EncriptedId { get; set; }

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa soyadı daxil edin"), MaxLength(50, ErrorMessage = "Soyad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "Soyad 2 hərfdən az ola bilməz!")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa ata adı daxil edin"), MaxLength(50, ErrorMessage = "Ata adı 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "Ad 2 hərfdən az ola bilməz!")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa maili daxil edin")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Zəhmət olmasa maili düzgün daxil edin")]
        public string Email { get; set; }
        [MaxLength(15, ErrorMessage = "Seriya nömrə 15dən çox ola bilməz!"), MinLength(3, ErrorMessage = "Seriya nömrə 3dən az ola bilməz!")]
        public string IdCard { get; set; }
        [MaxLength(8, ErrorMessage = "Fin nömrə 8 -dən çox ola bilməz!"), MinLength(3, ErrorMessage = "Fin nömrə 3dən az ola bilməz!")]
        public string FinCode { get; set; }
        //[Required(ErrorMessage = "Bu sahəni doldurmalısınlız!"), StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string Image { get; set; }
        public bool Status { get; set; }
        public bool IsWorking { get; set; }
        public bool IsCandidate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa ünvanı daxil edin"), StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string LivingAdress { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa ünvanı daxil edin"), StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string BirthPlace { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public int MarialstatusId { get; set; }
        public virtual MarialStatus Marialstatus { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Required(ErrorMessage = "Zəhmət olmasa doğum tarixini daxil edin")]
        public DateTime Birthday { get; set; }
        public int? PositionsId { get; set; }
        public decimal? Salary { get; set; }
        public virtual Position Positions { get; set; }
        public int? CompanyId { get; set; }
        public virtual Companies Company { get; set; }
        public int? MillitaryStatusId { get; set; }
        public string ScanCommand { get; set; }
        public int? WorkTimeOfTypeId { get; set; }
        public virtual WorkTimeOfType WorkTimeOfType { get; set; }
        //public int? TaxBreakId { get; set; }
        //public virtual TaxBreak TaxBreak { get; set; }
        public int? WorkBookAdditionId { get; set; }
        public virtual WorkBookAddition WorkBookAddition { get; set; }
        public int? WorkPlaceAdditionId { get; set; }
        public virtual WorkPlaceAddition WorkPlaceAddition { get; set; }
        public virtual MillitaryStatus MillitaryStatus { get; set; }
        public virtual ICollection<LastWorkPlace> LastWorkPlaces { get; set; }
        public virtual ICollection<LanguageToEmployee> LangugaeToEmployees { get; set; }
        public virtual ICollection<EducationsToEmployee> EducationsToEmployees { get; set; }
        public virtual ICollection<PhoneNumberToEmployee> PhoneNumberToEmployees { get; set; }
        public virtual ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }
      //  public virtual CommandsToEmployee CommandsToEmployee { get; set; }
        public virtual ICollection<DeviceToEmployee> DeviceToEmployees { get; set; }
        public virtual ICollection<RelationToEmployee> RelationToEmployees { get; set; }
        public virtual ICollection<PermissionToEmployeee> PermissionToEmployeees { get; set; }
        //public virtual ICollection<MillitaryStatus> Statuses { get; set; }
        public virtual ICollection<AdditionalInfos> AdditionalInfos { get; set; }
        public virtual ICollection<ComputerToEmployee> ComputerToEmployees { get; set; }
        public virtual ICollection<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<TaxBreakToEmplooyee> TaxBreakToEmplooyees { get; set; }
        public virtual ICollection<ExplanationToEmployee> ExplanationToEmployees { get; set; }
        //public virtual ICollection<DepBossPosition> DepBossPositions { get; set; }
        public virtual ICollection<ScanPdfCommands> ScanPdfCommands { get; set; }
        public virtual ICollection<HistoryPositionChange> HistoryPositionChanges { get; set; }
        public virtual ICollection<OldSalary> OldSalaries { get; set; }
        public virtual ICollection<TelMe> TelMes { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }
        public virtual ICollection<FreeVacation> FreeVacations { get; set; }
        public virtual ICollection<MessageForEmployee> MessageForEmployees { get; set; }
        public virtual ICollection<AllCommandsHistory> AllCommandsHistories { get; set; }
        public virtual ICollection<WorkDateToEmployee> WorkDateToEmployees { get; set; }
     
        public virtual ICollection<BusinessTripEmp> BusinessTripEmps { get; set; }
       // public   bool IsInVacation { get; set; }
        public int? ReminderVacationCount { get; set; }
        public int? AdditionalVacationDay { get; set; }





    }
}
