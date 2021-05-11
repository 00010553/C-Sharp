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
    public partial class AllApplicants : Form
    {
        public AllApplicants()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new ApplicantEdit().CreateNewApplicant();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("You don't selected and applicant ");
            else
            {
                var c = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantEdit().UpdateApplicant(c);
            }
        }
        public void DataLoad()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new SortApplicant().GetAllApplicants();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("You don't selected and applicant");
            else
            {
                var c = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                var Mess = MessageBox.Show("Are You Shure ? ", "Delete Record", MessageBoxButtons.YesNo);
                if (Mess == DialogResult.Yes)
                    new ApplicantManager().Delete(c.ap_id_10553);
                DataLoad();

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Please select an attribute first");
            else
            {
                ApplicantByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ApplicantByAttribute.ap_name_10553;
                else selectedAttribute = ApplicantByAttribute.ap_score_10553;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new SortApplicant().Sort(selectedAttribute);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select searching attribute");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Please provide the search term");
            else
            {
                ApplicantByAttribute selectedAttribute;
                if (cbxSearch.SelectedIndex == 0)
                    selectedAttribute = ApplicantByAttribute.ap_id_10553;
                else
                    selectedAttribute = ApplicantByAttribute.ap_name_10553;


                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new SortApplicant().Search(tbxSearch.Text, selectedAttribute);
            }
        }

        private void AllApplicants_Load(object sender, EventArgs e)
        {
            MdiParent = Forms.GetForm<ParentForm>();
            DataLoad();
        }
    }
}
