﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificaDebito
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //commento github
        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno(txtNome.Text, txtCognome.Text, int.Parse(txtEta.Text), txtCittaResidenza.Text);
            a.toString(txtNome.Text, txtCognome.Text, int.Parse(txtEta.Text), txtCittaResidenza.Text);
        }
        //Primo commit
    }
}
