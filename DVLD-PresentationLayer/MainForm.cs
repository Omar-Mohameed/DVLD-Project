using DVLD_PresentationLayer.People;

namespace DVLD_PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPeoples();
            frm.ShowDialog();
        }
    }
}
