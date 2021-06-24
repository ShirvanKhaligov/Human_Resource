using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.Models.FreeVacation;
using InternalSystem.Areas.Employee.Models.Vacation;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.ComputerSk;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
//using InternalSystem.Areas.InternalHR.Models.ComToHour;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Devices;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using InternalSystem.Areas.InternalHR.Models.Month;
using InternalSystem.Areas.InternalHR.Models.Permissions;
//using InternalSystem.Areas.InternalHR.Models.Quiz;kkkkkkkkkkk
using InternalSystem.Areas.InternalHR.Models.Relations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.InternalHR.DAL
{
    public class InternalSysDBContext : IdentityDbContext<AppUser>
    {
        public InternalSysDBContext(DbContextOptions<InternalSysDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

        }
        //protected override void OnModelCreating(DbContextOptionsBuilder builder)
        //{
        //    if (!builder.IsConfigured)
        //    {
        //        builder.UseSqlServer("Data Source=FCNT136; Initial Catalog=19.12.2020Hr02Nov-V2; Integrated Security=SSPI;");
        //    }
        //}

        public DbSet<Countries> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Emplooyee> Emplooyeees { get; set; }
        public DbSet<MillitaryRank> MillitaryRanks { get; set; }
        public DbSet<MillitaryStatus> MillitaryStatuses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SubDepartment> SubDepartments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<RelationType> RelationTypes { get; set; }
        public DbSet<Relations> Relations { get; set; }
        public DbSet<RelationToEmployee> RelationToEmployees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MarialStatus> MarialStatuses { get; set; }
        public DbSet<LastWorkPlace> LastWorks { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationTypeToUnivercity> EducationTypeToUnivercities { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<EducationsToEmployee> EducationsToEmployees { get; set; }
        public DbSet<Universities> Universities { get; set; }
        public DbSet<ContactBetweenDepartmentsSent> ContactBetweenDepartmentsSent { get; set; }
        public DbSet<ContactBetweenDepartmentsInbox> ContactBetweenDepartmentsInbox { get; set; }
        public DbSet<UniFaculty> UniFaculties { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<PhoneNumberToEmployee> PhoneNumberToEmployees { get; set; }
        public DbSet<PhoneNumbers> PhoneNumbers { get; set; }
        public DbSet<Commands> Commands { get; set; }
        public DbSet<CommandsToEmployee> CommandsToEmployees { get; set; }
        public DbSet<DeviceToEmployee> DeviceToEmployees { get; set; }
        public DbSet<DevicesType> DevicesTypes { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageLevel> LanguageLevels { get; set; }
        public DbSet<LanguageToEmployee> LanguageToEmployees { get; set; }
        public DbSet<LanguageToLanguageLevel> LanguageToLanguageLevels { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<PermissionToEmployeee> PermissionToEmployeees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public DbSet<Continuity> Continuities { get; set; }
        public DbSet<AdditionalInfos> AdditionalInfos { get; set; }
        public DbSet<ComputerLevels> ComputerLevels { get; set; }
        public DbSet<ComputerSkillsName> ComputerSkillsNames { get; set; }
        public DbSet<ComputerSkillToLevels> ComputerSkillToLevels { get; set; }
        public DbSet<ComputerToEmployee> ComputerToEmployees { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<WorkTimeOfType> WorkTimeOfTypes { get; set; }
        public DbSet<TaxBreak> TaxBreaks { get; set; }
        public DbSet<WorkBookAddition> WorkBookAdditions { get; set; }
        public DbSet<WorkPlaceAddition> WorkPlaceAdditions { get; set; }
        public DbSet<TaxBreakToEmplooyee> TaxBreakToEmplooyees { get; set; }
        public DbSet<ScanPdfQuitWork> ScanPdfQuitWorks { get; set; }
        //public DbSet<InternalSystem.Areas.Employee.Models.Extention> Extentions { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<RewardToEmployee> RewardToEmployees { get; set; }
        public DbSet<ScanForReward> ScanForRewards { get; set; }
        // public DbSet<InternalSystem.Areas.Employee.Models.Bio> Bios { get; set; }
        public DbSet<SocialLinks> Socials { get; set; }
        // public DbSet<Myclass> Myclasses { get; set; }

        //MonthFolder
        //  public DbSet<Year> Years { get; set; }
        //  public DbSet<Month> Months { get; set; }
        //  public DbSet<YearToMonth> YearToMonths { get; set; }
        //  public DbSet<Hour> Hours { get; set; }
        //

        //Explanation

        //display:block;
        public DbSet<Explanation> Explanations { get; set; }
        public DbSet<ExplanationToEmployee> ExplanationToEmployees { get; set; }

        //positionChange
        public DbSet<ScanPdfCommands> ScanPdfCommands { get; set; }
        public DbSet<HistoryPositionChange> HistoryPositionChanges { get; set; }
        public DbSet<OldSalary> OldSalaries { get; set; }

        public DbSet<TelMe> TelMes { get; set; }
        //AdditionalEqu
        public DbSet<AdditionalEquipment> AdditionalEquipments { get; set; }
        //WorkDate

        public DbSet<WorkDates> WorkDates { get; set; }
        public DbSet<WorkDateToEmployee> WorkDateToEmployees { get; set; }


        //Messaging
        public DbSet<AllCommandsHistory> AllCommandsHistories { get; set; }
        public DbSet<MessageForEmployee> MessageForEmployees { get; set; }
        //Vacation
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<VacationType> VacationTypes { get; set; }

        //BusinessTrip
        public DbSet<Distric> Districs { get; set; }
        public DbSet<BusinessTripEmp> BusinessTripEmps { get; set; }

        //Item
        public DbSet<Item> Items { get; set; }
        //DateOfTabel
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<HolidayOfCalendar> HolidayOfCalendars { get; set; }

        //FreeVac
        public DbSet<FreeVacation> FreeVacations { get; set; }
        public DbSet<FreeVacationType> FreeVacationTypes { get; set; }
        //Quiz


        //public DbSet<Answer> Answers { get; set; }
        //public DbSet<Choice> Choices { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<Quiz> Quizs { get; set; }

        //public DbSet<Exam_Result> GetExamResult { get; set; }
        //public DbSet<Microsoft.AspNetCore.Identity.IdentityUserClaim<Guid>> IdentityUserClaims { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //base.OnModelCreating(modelBuilder);
        //modelBuilder.Ignore<IdentityUserLogin<string>>();
        //modelBuilder.Ignore<IdentityUserRole<string>>();
        //modelBuilder.Ignore<IdentityUserClaim<string>>();
        //modelBuilder.Ignore<IdentityUserToken<string>>();
        //modelBuilder.Ignore<IdentityUser<string>>();

        //modelBuilder.Entity<IdentityUserClaim<string>>().HasKey(p => new { p.Id });

        //modelBuilder.Entity<Choice>()
        //    .Property(e => e.ChoiceText)
        //    .IsUnicode(false);

        //modelBuilder.Entity<Question>()
        //    .Property(e => e.QuestionText)
        //    .IsUnicode(false);

        //modelBuilder.Entity<Quiz>()
        //    .Property(e => e.QuizName)
        //    .IsUnicode(false);

        //modelBuilder.Entity < AppUser user > ()
        //      .Property(e => e.FullName)
        //.IsUnicode(false);

        //modelBuilder.Entity<User>()
        //    .Property(e => e.ProfilImage)
        //    .IsUnicode(false);

        //modelBuilder.Entity<Exam_Result>(builder =>
        //{
        //    builder.HasKey();
        //});
        //  base.OnModelCreating(modelBuilder);

        //}



    }
}
