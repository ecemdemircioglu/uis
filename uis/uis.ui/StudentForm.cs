using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uis.ui
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnStudentPictureUpload_Click(object sender, EventArgs e)
        {
           var pictureFile= openFileDialog1.ShowDialog(this);
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Refresh();
        }
    }
}
