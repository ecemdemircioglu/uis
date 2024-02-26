namespace uis.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm form= new StudentForm();
            form.ShowDialog();
        }
    }
}
