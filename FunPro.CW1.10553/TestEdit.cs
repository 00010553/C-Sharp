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
    public partial class TestEdit : Form
    {
        public TestEdit()
        {
            InitializeComponent();
        }

        public Test Test { get; set; }

        public Mode Mode { get; set; }

        public void CreateNewTest()
        {
            Mode = Mode.CreateNew;
            Test = new Test();

            MdiParent = Forms.GetForm<ParentForm>();
            Show();
        }

        private void ShowTestInControls()
        {

            tbxName.Text = Test.ts_name_10553;
            tbxQ1.Text = Test.ts_q1_10553;
            tbxQ2.Text = Test.ts_q2_10553;
            tbxQ3.Text = Test.ts_q3_10553;
            tbxQ1A.Text = Test.ts_q1_answer_10553;
            tbxQ2A.Text = Test.ts_q2_answer_10553;
            tbxQ3A.Text = Test.ts_q3_answer_10553;
        }

        private void GrabUserInput()
        {
            Test.ts_name_10553 = tbxName.Text;
            Test.ts_q1_10553 = tbxQ1.Text;
            Test.ts_q2_10553 = tbxQ2.Text;
            Test.ts_q3_10553 = tbxQ3.Text;
            Test.ts_q1_answer_10553 = tbxQ1A.Text;
            Test.ts_q2_answer_10553 = tbxQ2A.Text;
            Test.ts_q3_answer_10553 = tbxQ3A.Text;
        }
        public void UpdateTest(Test test)
        {
            Mode = Mode.Update;
            Test = test;

            ShowTestInControls();
            MdiParent = Forms.GetForm<ParentForm>();
            Show();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new TestManager();
                if (Mode == Mode.CreateNew)
                    manager.Create(Test);
                else
                    manager.Update(Test);

                Forms.GetForm<AllTests>().DataLoad();
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
