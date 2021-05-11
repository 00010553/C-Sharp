using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._10553.DAL
{
    public class SortTest
    {
        public List<Test> GetAllTest()
        {
            return new TestManager().GetAll();
        }

        private class Byts_name_10553Comparer : IComparer<Test>
        {
            public int Compare(Test x, Test y)
            {
                return string.Compare(x.ts_name_10553, y.ts_name_10553);
            }
        }

        public List<Test> Search(string value, TestByAttribute attribute)
        {
            switch (attribute)
            {
                case TestByAttribute.ts_id_10553:
                    return GetAllTest().Where(t => Convert.ToString(t.ts_id_10553).Contains(value.ToUpper())).ToList();
                case TestByAttribute.ts_name_10553:
                    return GetAllTest().Where(t => t.ts_name_10553.ToUpper().Contains(value.ToUpper())).ToList();
            }
            return null;
        }

    }
}
