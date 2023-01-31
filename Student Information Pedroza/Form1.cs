using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Information_Pedroza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(open.FileName);        
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String gender = "";

            if(rButtonM.Checked)
                {
                gender = "Male";
                }
            else 
            {
                gender = "Female";
            }

            int Bday1 = 0;
            int Bday2 = 0;
            int Bday3 = 0;

            Bday1 = dateTimePicker1.Value.Day;
            Bday2 = dateTimePicker1.Value.Month;
            Bday3 = dateTimePicker1.Value.Year;

            int age = 0;

            age = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.AddYears(age) > DateTime.Now) age --;

            String hobbies = "";

            if (cbDance.Checked)
                hobbies = hobbies + "\nDancing";
            if (cbSing.Checked)
                hobbies = hobbies + "\nSinging";
            if (cbGame.Checked)
                hobbies = hobbies + "\nGaming";
            if (cbMovie.Checked)
                hobbies = hobbies + "\nWatching Movies";
            if (cbRead.Checked)
                hobbies = hobbies + "\nReading";
            if (cbWorkout.Checked)
                hobbies = hobbies + "\nWorkout";



            String details = "";

            details = "Name:" + txtName.Text +
                      "\n Birthdate: " + Bday2 + "/" + Bday1 + "/" + Bday3 + 
                      "\n age: " + age +
                      "\n Gender: " + gender +
                      "\n Hobbies: " + hobbies;

            MessageBox.Show(details,"Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}