namespace DecisionsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal english = decimal.Parse(txtBoxEnglish.Text);
            decimal python = decimal.Parse(txtBoxPython.Text);
            decimal networking = decimal.Parse(txtBoxNetworking.Text);

            decimal total = english + python + networking;

            decimal average = total / 3;

            lblAvgResult.Text += " " + Math.Round(average, 2);

            string grade = "";

            if (average >= 90 && average <= 100)
            {
                grade = "A";
            }
            else if (average >= 80)
            {
                grade = "B";
            }
            else if (average >= 70)
            {
                grade = "C";
            }
            else if (average >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            lblGradeResult.Text += " " + grade;
        }
    }
}