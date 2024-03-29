﻿using MySB.Formulários;
using MySB.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySB
{
    public partial class Login : Form
    {
        private ServicoMySB _servico;
        public Login()
        {
            InitializeComponent();
            _servico = new ServicoMySB();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_servico.ValidaUsuarioLogin(txbLogin.Text.Trim(), mskSenha.Text.Trim()))
            {
                this.Hide();
                var menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
                              
                
            }
            else 
            {
                MessageBox.Show("Login ou Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
