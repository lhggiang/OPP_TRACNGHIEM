using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    public class User
    {
        private string ma;
        private string ten;
        private string email;
        private string matkhau;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}
