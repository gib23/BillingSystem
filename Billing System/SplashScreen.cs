using Billing_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billing_System.Utils;


namespace Billing_System
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            this.BackColor = AppTheme.PrimaryColor;
            //splashTimer.Start();

            pbLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoading.Image = Properties.Resources.loading; // Assuming you have a loading.gif in your resources
            pbLoading.BackColor = Color.Transparent; // Make the PictureBox background transparent
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            //splashTimer.Stop();
            // Close the splash and open the Login Form
            //this.Hide();
            //var loginForm = new LoginForm();


            //// When login form actually closes, close the hidden splash so the app can exit cleanly.
            //loginForm.FormClosed += (s, args) => this.Close();
            //loginForm.Show();

        }
    }
}
