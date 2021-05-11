using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._10553.DAL
{
   public class SortApplicant
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

        public List<Applicant> Sort(ApplicantByAttribute attribute)
        {
            var result = GetAllApplicants();

            switch (attribute)
            {
                case ApplicantByAttribute.ap_name_10553:
                    result.Sort(new Byap_name_10553Comparer());
                    return result;
                case ApplicantByAttribute.ap_score_10553:
                    result.Sort(new Byap_score_10553Comparer());
                    return result;

            }
            return null;
        }

        private class Byap_name_10553Comparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.ap_name_10553, y.ap_name_10553);
            }
        }

        private class Byap_score_10553Comparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                return string.Compare(x.ap_score_10553, y.ap_score_10553);
            }
        }

        public List<Applicant> SortLinq(ApplicantByAttribute attribute)
        {
            switch (attribute)
            {
                case ApplicantByAttribute.ap_name_10553:
                    return GetAllApplicants().OrderBy(a => a.ap_name_10553).ToList();
                case ApplicantByAttribute.ap_score_10553:
                    return GetAllApplicants().OrderBy(a => a.ap_score_10553).ToList();                
            }
            return null;
        }

        public List<Applicant> Search(string value, ApplicantByAttribute attribute)
        {
            switch (attribute)
            {
                case ApplicantByAttribute.ap_id_10553:
                    return GetAllApplicants().Where(a => Convert.ToString(a.ap_id_10553).Contains(value.ToUpper())).ToList();
                case ApplicantByAttribute.ap_name_10553:
                    return GetAllApplicants().Where(a => a.ap_name_10553.ToUpper().Contains(value.ToUpper())).ToList();
            }
            return null;
        }

    }
}
