using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Devices
{
    public class Device
    {

        public int Id { get; set; }
        public string InventorCode { get; set; }
        public string Parametr { get; set; }
        public int? Count { get; set; }
        public string SerialNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{DD/MM/YYYY}")]
        public DateTime GivingTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{DD/MM/YYYY}")]
        public DateTime? ReturnDate { get; set; }
        public string PhoneNumber { get; set; }
        public string InternalPhoneNumber { get; set; }
        public bool Status { get; set; }
        public int? DevicesTypeId { get; set; }
        public string Reason { get; set; }
        public virtual DevicesType DevicesType { get; set; }
        public DateTime TimeOfExecution { get; set; }
        public virtual ICollection<DeviceToEmployee> DeviceToEmployees { get; set; }

        //public int Id { get; set; }
        //[Required(ErrorMessage ="Zəhmət olmasa xananı boş buraxmayın")]
        //[StringLength(100, ErrorMessage = "Simvol sayı 100-dən çox ola bilməz!")]
        //public string Name { get; set; }
        ////--new--//

        //[StringLength(200, ErrorMessage = "Simvol sayı 200-dən çox ola bilməz!")]
        //public string Parametr { get; set; }

        //[StringLength(200, ErrorMessage = "Simvol sayı 200-dən çox ola bilməz!")]
        //public string SeriaNumber { get; set; }
        //public int MouseCount { get; set; }
        //public int HeadPhoneCount { get; set; }
        //public int IpPhoneNumber { get; set; }
        //public virtual AdditionalEquipment AdditionalEquipment { get; set; }
        //public int InternalNumber { get; set; }

        //public bool Status { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa vaxtı qeyd edin")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{DD/MM/YYYY}")]
        //public DateTime GivingTime { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{DD/MM/YYYY}")]
        //public DateTime? ReturnDate { get; set; }
        //public int? DevicesTypeId { get; set; }
        //public virtual DevicesType DevicesType { get; set; }
        //public virtual ICollection<DeviceToEmployee> DeviceToEmployees { get; set; }

        //[StringLength(155, ErrorMessage = "Simvol sayı 155dən artıq ola bilməz")]
        //public string Reason { get; set; }









        //public DateTime TimeOfExecution { get; set; }




    }
}
