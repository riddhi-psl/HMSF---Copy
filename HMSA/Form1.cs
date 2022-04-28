using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSA
{
    public partial class Form1 : Form
    {
        String path = "Data Source=(localdb)\\MSSqlLocalDB; Initial Catalog=hospital; Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) { }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Register(username,password,confirm_password) " +
                    "values('" + txtUser.Text + "', '" + txtPass.Text + "', '" + txtCpass.Text + "')";
                //cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //string name;
                MessageBox.Show("User has been Registerd");
               
                    panelLogin.Visible = true;
                //panelRegister.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == txtUserName.Text && txtCpass.Text == txtPassword.Text)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Register where username = '" + txtUser.Text + "'and password = '" + txtPass.Text + "'";
                //cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                SqlDataReader dbr;

                con.Open();

                dbr = cmd.ExecuteReader();

                int count = 0;

                while (dbr.Read())

                {

                    count = count + 1;

                }

                if (count == 1)

                {


                }

                else if (count > 1)

                {


                }

                else

                {


                }

            }

            else

            {


            }
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        /*private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }*/

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            //panelRegister.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }
    }
    }

