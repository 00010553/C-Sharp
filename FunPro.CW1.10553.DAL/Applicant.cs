using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._10553.DAL
{
   public class Applicant
    {
        private string _ap_name_10553;

        public int ap_id_10553 { get; set; }

        public string ap_name_10553
        {
            get => _ap_name_10553;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Please fill in the Name!");
                _ap_name_10553 = value;
            }
        }
        public string ap_score_10553 { get; set; }

        public string ap_tests_taken_10553 { get; set; }
    }
}

