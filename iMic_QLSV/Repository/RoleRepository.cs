using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Repository
{
    public class RoleRepository
    {
        SinhVienEntities dbContext = new SinhVienEntities();

        public List<Role> GetAllRole()
        {
            var role = from r in dbContext.Roles
                       select r;
            return role.ToList();
        }
    }
}
