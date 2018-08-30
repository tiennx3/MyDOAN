﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP_Ketnoi;

namespace code_PC_doan
{
    public partial class Dangnhapdatabase : Form
    {
        public Dangnhapdatabase()
        {
            InitializeComponent();
            
        }
        Ketnoi ketnoi = new Ketnoi();
        private void BT_connect_Click(object sender, EventArgs e)
        {
            //ketnoi.ip_host = TB_iphost.Text;
            //ketnoi.database = TB_database.Text;
            //ketnoi.user = TB_user.Text;
            //ketnoi.password = TB_password.Text;
            string strconnect= "Server='"+ TB_iphost.Text + "';Database="+ TB_database.Text + ";Port=3306;User ID="+ TB_user.Text + ";Password="+ TB_password.Text + "";
            ketnoi.strconnection = strconnect;
            try
            {
                ketnoi.OpenConnection();
                MessageBox.Show("Ok.", "Đăng nhập thành công!");
                main main = new main();
                main.strconnection = strconnect;
                this.Hide();
                main.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No Ok.", "Đăng nhập thất bại!");
            }
        }

        private void Dangnhapdatabase_Load(object sender, EventArgs e)
        {
            TB_database.Text = "nurs_home";
            TB_iphost.Text = "172.20.10.3";
            TB_user.Text = "root";
        }
    }
}
