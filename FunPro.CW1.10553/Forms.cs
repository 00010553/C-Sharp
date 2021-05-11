using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW1._10553.DAL
{
     class Forms
    {
        public static a GetForm<a>() where a : class, new()
        {
            return Application.OpenForms.OfType<a>().FirstOrDefault() ?? new a();
        }
    }
}
