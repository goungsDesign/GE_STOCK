using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_STOCK.Models
{
    public class User
    {
        public int Id { get; set; }
        public  string Login { get; set; }
        public string PWD { get; set; }
        public Role Role { get; set; }

    }
}
