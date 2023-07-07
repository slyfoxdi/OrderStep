﻿using OrderStep.Api.Extension.Http;
using OrderStep.Api.Intregration;
using OrderStep.Api.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderStep.Api
{
    public partial class Auth : Form
    {
        private readonly IAuthReference _authService;

        public Auth()
        {
            InitializeComponent();
            var httpClientService = new OrderStepHttpClientService("http://localhost:5143/", string.Empty, string.Empty);
            _authService = new AuthReference(httpClientService);
        }
                
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            var auth = _authService.Authentification(login, password);
           
            if(auth == null)
            {
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                authLabel1.Text = "Произошла непредвиденная ошибка";
                authLabel1.ForeColor = Color.Red;
                return;
            }

            if (auth.Status == StatusCode.FailedAuthentification) 
            {
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                authLabel1.Text = auth.Message;
                authLabel1.ForeColor = Color.Red;
                return;
            }

            if (auth.Status == StatusCode.Success)
            {
                var form2 = new Order(auth.Response);
                form2.Show(this);
                Hide();
            }
        }
    }
}
