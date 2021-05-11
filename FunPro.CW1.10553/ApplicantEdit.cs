using FunPro.CW1._10553.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW1._10553
{
    public partial class ApplicantEdit : Form
    {
        public ApplicantEdit()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }

        public Mode Mode { get; set; }

        public void CreateNewApplicant()
        {
            Mode = Mode.CreateNew;
            Applicant = new Applicant();

            MdiParent = Forms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            Mode = Mode.Update;
            Applicant = applicant;
            ShowApplicantInControls();
            MdiParent = Forms.GetForm<ParentForm>();
            Show();
        }

        private void ShowApplicantInControls()
        {

            tbxName.Text = Applicant.ap_name_10553;
            tbxScore.Text = Convert.ToString(Applicant.ap_score_10553);
            tbxTestsTaken.Text = Applicant.ap_tests_taken_10553;

        }

        private void GrabUserInput()
        {
            Applicant.ap_name_10553 = tbxName.Text;
            Applicant.ap_score_10553 = tbxScore.Text;
            Applicant.ap_tests_taken_10553 = tbxTestsTaken.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new ApplicantManager();
                if (Mode == Mode.CreateNew)
                    manager.Create(Applicant);
                else
                    manager.Update(Applicant);

                Forms.GetForm<AllApplicants>().DataLoad();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
