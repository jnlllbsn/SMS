using SMS.Domain;
using SMS.Infastructure.Data;

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
            using (var dbContext = new AppDbContext()) //using keyword is to avoid "attacks"
            {
                var program = dbContext.Programs.Where(p => p.ProgramName == "EE").FirstOrDefault();
                createStudent(program.ProgramId, program.ProgramName, program.Description);
            } //to debug
            //buttonShow_Click(sender, e);
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
                Email = email,
                DateAdded = DateTime.Now,
                AddedBy = "Admin"
            };
            textBoxEmail.Text = student.Email;
            textBoxID.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;

            //labelAddedInformation.Text = "Added By: " + student.AddedBy + " " + student.DateAdded; : less formal concatenation
            labelAddedInformation.Text = $"Added By: {student.AddedBy} {student.DateAdded}";
        }
    }
}
