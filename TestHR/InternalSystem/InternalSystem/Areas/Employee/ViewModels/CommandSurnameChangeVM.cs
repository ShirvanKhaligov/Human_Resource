using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CommandSurnameChangeVM
    {

        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin")]
        public int? EmplooyeeId { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vaxtı seçin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa faylı seçin")]
        public IFormFile Photo { get; set; }
        public IFormFile PhotoUpd { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa soyadı daxil edin")]
        [StringLength(50, ErrorMessage = "Simvol sayı 50dən artıq ola bilməz")]
        public string NewSurname { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public AllCommandsHistory AllCommandsHistory { get; set; }
    }
}
