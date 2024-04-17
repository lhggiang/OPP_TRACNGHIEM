using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    public abstract class LopBase
    {
        public abstract void ThemDeThi(string deThi);
        public abstract List<string> getDanhSachDeThi(string MaLop);
    }
}


