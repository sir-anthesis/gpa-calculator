namespace Ihza_T1
{
    public partial class Form1 : Form
    {
        Module obj = new Module();
        string[] nama = new string[3];
        double[] test = new double[3];
        double[] assignment = new double[3];
        double[] credit = new double[3];
        double[] grade_value = new double[3];
        int i;
        double gpa;
        public Form1()
        {
            InitializeComponent();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            obj.module_name = txmodule.Text;
            obj.module_test = Convert.ToDouble(nutest.Value);
            obj.assignment = Convert.ToDouble(nuassign.Value);
            obj.credit_value = Convert.ToDouble(nucv.Value);

            if (obj.module_name == "")
            {
                MessageBox.Show("Nama Module Tidak Boleh Kosong");
            }
            else
            {
                if (i < 3)
                {
                    nama[i] = obj.module_name;
                    test[i] = obj.module_test;
                    assignment[i] = obj.assignment;
                    credit[i] = obj.credit_value;

                    lbresult.Text = obj.Calculate().ToString();
                    lbgrade.ForeColor = Color.Green;
                    lbresult.ForeColor = Color.Green;
                    if (obj.result >= 80)
                    {
                        lbgrade.Text = "A";
                        obj.grade = "A";
                        grade_value[i] = 4;
                    }
                    else if (obj.result >= 70)
                    {
                        lbgrade.Text = "B";
                        obj.grade = "B";
                        grade_value[i] = 3;
                    }
                    else if (obj.result >= 60)
                    {
                        lbgrade.Text = "C";
                        obj.grade = "C";
                        grade_value[i] = 2;
                    }
                    else if (obj.result >= 50)
                    {
                        lbgrade.Text = "D";
                        obj.grade = "D";
                        grade_value[i] = 1;
                    }
                    else
                    {
                        lbgrade.Text = "E";
                        obj.grade = "E";
                        grade_value[i] = 0;
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
            foreach (double C in credit)
            {
                total += C;
            }
            return total;
        }

        private double getTotalGV()
        {
            double total = 0;
            for (int j = 0; j < credit.Length; j++)
            {
                total += credit[j] * grade_value[j];
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
