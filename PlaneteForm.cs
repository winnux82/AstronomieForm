using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomieForm
{
    public partial class PlaneteForm : Form
    {
        public PlaneteForm()
        {
            InitializeComponent();
        }


        private void TxbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }




        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if(IsNotEmptyOnlyLetters(TxbNom.Text)&& IsOnlyDigt(TxbMasse.Text))
            {

                if(TxbGalaxie.Text=="")
                {

                    Planete Planete0 = new Planete(TxbNom.Text, Convert.ToInt32(TxbDiamètre.Text), Convert.ToInt32(TxbMasse.Text));

                    new GalaxieForm().ShowDialog();
                   this.Hide();
                   this.Dispose();
                   return;
                }
                Planete Planete1 = new Planete(TxbNom.Text,Convert.ToInt32(TxbDiamètre.Text), Convert.ToInt32(TxbMasse.Text));
                MessageBox.Show(Planete1.Description());

            }
            else
            {
                throw new ExceptionSaisie("Une erreur de saison empêche l'aout de la planète");
            }
        }
        public class ExceptionSaisie : Exception
        {
            public ExceptionSaisie(string message) : base(message)
            {
            }
        }
        public static bool IsNotEmptyOnlyLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            foreach (char caractere in s)
            {
                if (!char.IsLetter(caractere))
                    return false;
            }

            return true;
        }

        public static bool IsOnlyDigt(string s)
        {

            foreach (char caractere in s)
            {
                if (!char.IsDigit(caractere))
                    return false;
            }

            return true;
        }

    }
}
