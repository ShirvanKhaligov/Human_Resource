using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Holidays
    {
        public int Id { get; set; }
        public DateTime Holiday { get; set; }
        public string Description { get; set; }
    }
    public interface a
    {
        void Run();
    }
    public interface b 
    { 
        void Run();
    }
    public class c : a, b
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
