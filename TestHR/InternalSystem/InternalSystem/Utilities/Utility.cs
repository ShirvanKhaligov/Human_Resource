using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Utilities
{
    public static class Utility
    {
        public enum Roles
        {
            Admin,
            Member,
            SuperAdmin,
            HumanResource,
            DepartmentBoss, HrDepartmentBoss,DeviceResponsible,Director
        }

        public static bool DeleteImageFromFolder(this string root, string image)
        {
            string path = Path.Combine(root, "allUserImg", image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }

        public const string AdminRole = "Admin";
        public const string MemberRole = "Member";
        public const string SuperAdminRole = "SuperAdmin";
        public const string HumanresourceRole = "HumanResource";
        public const string DepartmentBossRole = "DepartmentBoss";

        public const string HrDepartmentBossRole = "HrDepartmentBoss";
        public const string DeviceResponsibleRole = "DeviceResponsible";
        public const string DirectorRole = "Director";

    }
}
