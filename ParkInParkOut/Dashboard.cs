
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ParkInParkOut
{
    public partial class ParkInDash : Form
    {
        
        ParkInPanel parkInPanel2;
        
        public ParkInDash()
        {
            InitializeComponent();
            this.Controls.Remove(parkInPanel1);
            instantiatePanels();
            this.StartPosition = FormStartPosition.CenterScreen;
            Button2();
            logoutButtons();
            parkOutResult1.Hide();
            parkOutPanel1.Hide();
            noParkedInMessage1.Hide();
            successFulParkInMessage1.Hide();
            parkOutResult1.setDashboard(this);
            errorDateTimeMessage1.setDash(this);
            errorDateTimeMessage1.Hide();
            parkOutPanel1.setErrorDatTimeMessage(errorDateTimeMessage1);
        }

        private void logoutButtons() { 
            logoutButton.BackColor = Color.White;
            logoutButton.ForeColor = Color.Navy;
            logoutButton.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void instantiatePanels() {
            
            parkOutPanel1.setParkOutResult(parkOutResult1);

            parkInPanel2 = new ParkInPanel(parkOutPanel1, parkOutResult1);
            this.parkInPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.parkInPanel2.Location = new System.Drawing.Point(220, 0);
            this.parkInPanel2.Name = "parkInPanel1";
            this.parkInPanel2.Size = new System.Drawing.Size(1032, 799);
            this.parkInPanel2.TabIndex = 12;
            this.Controls.Add(parkInPanel2);
            parkOutPanel1.setParkInPanel(parkInPanel2);

            parkInPanel2.SetSuccessfulMessage(successFulParkInMessage1);
            successFulParkInMessage1.setParkInPanel(parkInPanel2);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, parkInPanel2, parkOutPanel1, parkOutResult1, noParkedInMessage1);
            this.Visible = false;
            Thread.Sleep(250);
            loginForm.Show();
        }
        private void Button2()
        {
            exitButton.TabStop = false;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.BackColor = Color.Purple;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = exitButton.BackColor;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Purple;
            exitButton.ForeColor = SystemColors.ButtonFace;

        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(150, 0, 0);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            exitButton.FlatAppearance.MouseOverBackColor = Color.Purple;
            exitButton.ForeColor = Color.Red;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.White;
            logoutButton.ForeColor = Color.Navy;

        }
        private void logoutButton_MouseDown(object sender, MouseEventArgs e)
        {
            logoutButton.ForeColor = Color.FromArgb(150, 0, 0);
        }
        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.FlatAppearance.MouseOverBackColor = Color.Navy;
            logoutButton.ForeColor = Color.White;
        }

        private void parkOutButton_MouseLeave(object sender, EventArgs e)
        {
            parkOutButton.BackColor = Color.FromArgb(0, 0, 64);
            parkOutButton.ForeColor = Color.White;

        }

        private void parkOutButton_MouseEnter(object sender, EventArgs e)
        {
            parkOutButton.FlatAppearance.MouseOverBackColor = Color.Navy;
            parkOutButton.ForeColor = Color.White;
        }

        private void parkInButton_MouseLeave(object sender, EventArgs e)
        {
            parkInButton.BackColor = Color.FromArgb(0, 0, 64);
            parkInButton.ForeColor = Color.White;

        }
 
        private void parkInButton_MouseEnter(object sender, EventArgs e)
        {
            parkInButton.FlatAppearance.MouseOverBackColor = Color.Navy;
            parkInButton.ForeColor = Color.White;
            
        }


        public void parkOutButton_Click(object sender, EventArgs e)
        {
            parkInPanel2.Hide();
            parkOutResult1.Hide();
            successFulParkInMessage1.Hide();
            errorDateTimeMessage1.Hide();
            
            if (parkInPanel2.getCounter()==0)
            {
                noParkedInMessage1.Show();
                parkOutPanel1.Hide();
            }
            else
            {
                parkOutPanel1.Show();
                parkOutPanel1.Invalidate();
                noParkedInMessage1.Hide();
            }
        }

        

        private void parkInButton_Click(object sender, EventArgs e)
        {

            parkInPanel2.Show();
            parkOutResult1.Hide();
            parkOutPanel1.Hide();
            noParkedInMessage1.Hide();
            successFulParkInMessage1.Hide();
            errorDateTimeMessage1.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
