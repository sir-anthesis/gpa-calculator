namespace Ihza_T1
{
    public partial class Form1 : Form
    {
        Module obj = new Module();
        public Form1()
        {
            InitializeComponent();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            obj.module_name = txmodule.Text;
            obj.module_test = Convert.ToDouble(nutest.Value);
            obj.assignment = Convert.ToDouble(nuassign.Value);

            if (obj.module_name == "")
            {
                MessageBox.Show("Nama Module Tidak Boleh Kosong");
            }
            else 
            { 
                lbresult.Text = obj.Calculate().ToString();
                lbgrade.ForeColor = Color.Green;
                lbresult.ForeColor = Color.Green;
                if (obj.result >= 80)
                {
                    lbgrade.Text = "A";
                    obj.grade = "A";
                }
                else if (obj.result >= 70)
                {
                    lbgrade.Text = "B";
                    obj.grade = "B";
                }
                else if (obj.result >= 60)
                {
                    lbgrade.Text = "C";
                    obj.grade = "C";
                }
                else if (obj.result >= 50)
                {
                    lbgrade.Text = "D";
                    obj.grade = "D";
                }
                else
                {
                    lbgrade.Text = "E";
                    obj.grade = "E";
                    lbgrade.ForeColor = Color.Red;
                    lbresult.ForeColor = Color.Red;
                }

                switch (obj.grade)
                {
                    case "A":
                        MessageBox.Show("Excelent");
                        break;
                    case "B":
                        MessageBox.Show("Very Good");
                        break;
                    case "C":
                        MessageBox.Show("Good");
                        break;
                    case "D":
                        MessageBox.Show("Enough");
                        break;
                    case "E":
                        MessageBox.Show("Failed");
                        break;
                }
            }
        }
    }
}
