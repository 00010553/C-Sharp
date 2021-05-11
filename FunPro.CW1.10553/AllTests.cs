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
    public partial class AllTests : Form
    {
        public AllTests()
        {
            InitializeComponent();
        }

        public void DataLoad()
        {
            dgv1.DataMember = ""; 
            dgv1.DataSource = null;
            dgv1.DataSource = new SortTest().GetAllTest();
        }
        private void AllTests_Load(object sender, EventArgs e)
        {
            MdiParent = Forms.GetForm<ParentForm>();
            DataLoad();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new TestEdit().CreateNewTest();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
                MessageBox.Show("You don't selected a test ");
            else
            {
                var T = (Test)dgv1.SelectedRows[0].DataBoundItem;
                new TestEdit().UpdateTest(T);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
                MessageBox.Show("You don't selected a test");
            else
            {
                var T = (Test)dgv1.SelectedRows[0].DataBoundItem;
                var Mess= MessageBox.Show("Are You Shure ? ", "Delete Record", MessageBoxButtons.YesNo);
                if (Mess==DialogResult.Yes)
                    new TestManager().Delete(T.ts_id_10553);
                DataLoad();

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

       
    }
}
