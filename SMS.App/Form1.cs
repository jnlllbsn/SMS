using SMS.Domain;

namespace SMS.App
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

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonShow_Click(sender, e);
            //createStudent(1, "Shakira", "sha@kira.com");
        }
        
        private void buttonShow_Click(object sender, EventArgs e)
        {
            
            createStudent(2, "Joan Dela Cruz", "joan@delacruz.com");
            
        }

        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email
            };
            textBoxEmail.Text = student.Email;
            textBoxID.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
        }
    }
}
