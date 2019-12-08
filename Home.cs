using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Test
{
    public partial class Home : Form
    {
        FinalTestEntities db = new FinalTestEntities();

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TBuser.Text;
            string password = TBpw.Text;


            var user = db.akuns.Where(val => val.username == username).ToList().FirstOrDefault();

            if (username == "" || password == "")
            {
                MessageBox.Show("Harap isi Username dan Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user != null)
                {
                    if (password == user.password)
                    {
                        MessageBox.Show("Login Berhasil", "Form Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Onery frm2 = new Onery();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usernametidak di temukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
