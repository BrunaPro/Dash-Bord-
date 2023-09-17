using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project_01
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height =btnDashBoard.Height;
            pnlNav.Top =btnDashBoard.Top;   
            pnlNav.Left =btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            pnlNav.Left =btnCalender.Left;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btbContectUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btbContectUs.Height;
            pnlNav.Top = btbContectUs.Top;
            pnlNav.Left = btbContectUs.Left;
            btbContectUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSetings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetings.Height;
            pnlNav.Top = btnSetings.Top;
            pnlNav.Left = btnSetings.Left;
            btnSetings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashBoard_Leave(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btbContectUs_Leave(object sender, EventArgs e)
        {
            btbContectUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetings_Leave(object sender, EventArgs e)
        {
            btnSetings.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}