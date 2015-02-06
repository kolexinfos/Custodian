using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custodians.Models
{
    public class Custodian
    {
        public int ID { get; set; }
        public string Firstname {get; set;}
        public string Lastname {get; set;}
        public string AOM { get; set; }
        public string BOM { get; set; }

        public IEnumerable<string> SOLID { get; set; }

        public string Email { get; set; }
        public ICollection<Terminals> terminals { get; set; }

        public List<string> GetSOLID(int  UserId)
        {
            List<string> solid = new List<string>();

            using (gssdb_cards context = new gssdb_cards())
            {
                var all = from u in context.DNN_Users
                          join r in context.DNN_UserRoles on u.UserID equals r.UserID
                          join ur in context.DNN_Roles on r.RoleID equals ur.RoleID
                          where u.UserID == UserId
                          select new {rolename = ur.RoleName  };

                foreach (var data in all)
                {
                    solid.Add(data.rolename);
                }
            }

           
            
            return solid;
        }
    }
}