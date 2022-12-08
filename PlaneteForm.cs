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
            TextBox txb = (TextBox)sender;

            if (txb.Text.IndexOf('.') == -1)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }




        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if(IsNotEmptyOnlyLetters(TxbNom.Text)&& IsOnlyDigit(TxbMasse.Text))
            {
                try
                {
                    if (TxbGalaxie.Text == "")
                    {

                        Planete Planete0 = new Planete(TxbNom.Text, float.Parse(TxbDiamètre.Text), float.Parse(TxbMasse.Text));

                        new GalaxieForm().ShowDialog();
                        this.Hide();
                        this.Dispose();
                        return;
                    }
                    Galaxie GalaxieBoum = new Galaxie(TxbGalaxie.Text);
                    Galaxie.lstGalaxie = new List<Galaxie>();

                    if (!Galaxie.lstGalaxie.Contains(GalaxieBoum))
                    {
                        Galaxie.lstGalaxie.Add(GalaxieBoum);
                    }
                    else
                    {
                        MessageBox.Show("La galaxie existe déjà");
                    }

                    //Planete Planete1 = new Planete(TxbNom.Text, float.Parse(TxbDiamètre.Text), float.Parse(TxbMasse.Text));

                    //MessageBox.Show(Planete1.Description());
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
            else
            {
                MessageBox.Show("oups");
                //throw new ExceptionSaisie("Une erreur de saisie empêche l'ajout de la planète");
                //return;

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

        public static bool IsOnlyDigit(string s)
        {

            foreach (char caractere in s)
            {
                if (!(char.IsDigit(caractere)|| char.IsControl(caractere) || caractere == '.'))
                    return false;
            }

            return true;
        }

    }
}
