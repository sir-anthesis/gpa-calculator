namespace Ihza_T1
{
    public partial class Form1 : Form
    {
        Module[] obj = new Module[3];
        int i;
        double gpa;
        public Form1()
        {
            InitializeComponent();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (txmodule.Text == "")
            {
                MessageBox.Show("Nama Module Tidak Boleh Kosong");
            }
            else
            {
                if (i < 3)
                {
                    obj[i] = new Module();
                    obj[i].module_name = txmodule.Text;
                    obj[i].module_test = Convert.ToDouble(nutest.Value);
                    obj[i].assignment = Convert.ToDouble(nuassign.Value);
                    obj[i].credit_value = Convert.ToDouble(nucv.Value);

                    lbresult.Text = obj[i].Calculate().ToString();
                    lbgrade.ForeColor = Color.Green;
                    lbresult.ForeColor = Color.Green;
                    if (obj[i].result >= 80)
                    {
                        lbgrade.Text = "A";
                        obj[i].grade = "A";
                        obj[i].grade_value = 4;
                    }
                    else if (obj[i].result >= 70)
                    {
                        lbgrade.Text = "B";
                        obj[i].grade = "B";
                        obj[i].grade_value = 3;
                    }
                    else if (obj[i].result >= 60)
                    {
                        lbgrade.Text = "C";
                        obj[i].grade = "C";
                        obj[i].grade_value = 2;
                    }
                    else if (obj[i].result >= 50)
                    {
                        lbgrade.Text = "D";
                        obj[i].grade = "D";
                        obj[i].grade_value = 1;
                    }
                    else
                    {
                        lbgrade.Text = "E";
                        obj[i].grade = "E";
                        obj[i].grade_value = 0;
                        lbgrade.ForeColor = Color.Red;
                        lbresult.ForeColor = Color.Red;
                    }

                    switch (obj[i].grade)
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
                    i++;
                }
                else
                {
                    MessageBox.Show("Data tidak boleh lebih dari tiga");
                }
            }
        }

        private double getTotalCredit()
        {
            double total = 0;
            foreach (Module mod in obj)
            {
                total += mod.credit_value;
            }
            return total;
        }

        private double getTotalGV()
        {
            double total = 0;
            for (int j = 0; j < 3; j++)
            {
                total += obj[j].credit_value * obj[j].grade_value;
            }
            return total;
        }

        private void btgpa_Click(object sender, EventArgs e)
        {
            gpa = getTotalGV() / getTotalCredit();
            MessageBox.Show("GPA = " + Math.Round(gpa, 2));
        }
    }
}
