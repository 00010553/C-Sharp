using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._10553.DAL
{
    public class Test
    {
        private string _ts_name_10553;

        public int ts_id_10553 { get; set; }

        public string ts_name_10553
        {
            get => _ts_name_10553;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Please Enter name for test");
                _ts_name_10553 = value;
            }
        }
        public string ts_q1_10553 { get; set; }
        public string ts_q1_answer_10553 { get; set; }
        public string ts_q2_10553 { get; set; }
        public string ts_q2_answer_10553 { get; set; }
        public string ts_q3_10553 { get; set; }
        public string ts_q3_answer_10553 { get; set; }


    }
}
