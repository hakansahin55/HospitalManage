using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HospitalManage.Helpers;

namespace HospitalManage
{
    public partial class Mainpage : Form
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

        public Mainpage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = MaınMenubtn.Height;
            PnlNav.Top = MaınMenubtn.Top;
            PnlNav.Left = MaınMenubtn.Left;
            MaınMenubtn.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Main Menu";
            this.panelFormLoader.Controls.Clear();
            MainMenu main = new MainMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(main);
            main.Show();
        }

        #region Drag Form
        private void move()
        {
            GlobalFunctions.ReleaseCapture();
            GlobalFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            move();
        }

        private void topPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            move();
        }
        #endregion



        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void MaınMenubtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = MaınMenubtn.Height;
            PnlNav.Top = MaınMenubtn.Top;
            PnlNav.Left = MaınMenubtn.Left;
            MaınMenubtn.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Main Menu";
            this.panelFormLoader.Controls.Clear();
            MainMenu main = new MainMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(main);
            main.Show();
        }

        private void MyCheckbtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = MyCheckbtn.Height;
            PnlNav.Top = MyCheckbtn.Top;
            MyCheckbtn.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "My Check-Ups";
            this.panelFormLoader.Controls.Clear();
            MyCheckups main = new MyCheckups() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(main);
            main.Show();
        }

        private void Appointbtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Appointbtn.Height;
            PnlNav.Top = Appointbtn.Top;
            Appointbtn.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Appointments";
            this.panelFormLoader.Controls.Clear();
            Appointments main = new Appointments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(main);
            main.Show();
        }

        private void Infobtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Infobtn.Height;
            PnlNav.Top = Infobtn.Top;
            Infobtn.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Informations";
            this.panelFormLoader.Controls.Clear();
            Information main = new Information() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelFormLoader.Controls.Add(main);
            main.Show();
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MaınMenubtn_Leave(object sender, EventArgs e)
        {
            MaınMenubtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void MyCheckbtn_Leave(object sender, EventArgs e)
        {
            MyCheckbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Appointbtn_Leave(object sender, EventArgs e)
        {
            Appointbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Infobtn_Leave(object sender, EventArgs e)
        {
            Infobtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void logOutbtn_Leave(object sender, EventArgs e)
        {
            logOutbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

       
    }
}
