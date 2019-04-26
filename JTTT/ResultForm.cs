using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JTTT
{
    public partial class ResultForm : Form
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public MemoryStream Imagestream { get; set; }

        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            textboxTemat.Text = Subject;
            textBoxOpis.Text = Body;
            pictureBox1.Image = Image.FromStream(Imagestream);

        }
    }
}
