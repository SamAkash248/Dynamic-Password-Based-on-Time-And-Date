using System;
using System.Drawing;
using System.Windows.Forms;
using TimeSecure;

namespace UI
{
    public partial class TS : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public TS()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string pass = input1.Text;
            CONVERTOR.Encrypt(pass, out string encode);
            CONVERTOR.Decrypt(encode, out string decode);
            CONTROLLER.MDDGenerator(out string mdd);
            CONTROLLER.TCGenerator(out string tc);
            string newpass = "VJ*" + mdd + tc;
            if (newpass == decode)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Password OK";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Password Denied";
            }
        }

        private void UI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            StartTimer();
        }

        System.Windows.Forms.Timer tmr = null;
        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            this.timelabel.Text = DateTime.Now.ToString("hh:mm");
            this.sec.Text = DateTime.Now.ToString("ss");
        }

    }
}
