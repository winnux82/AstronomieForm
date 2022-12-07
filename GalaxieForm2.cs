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
    public partial class GalaxieForm2:Form
    {
        public GalaxieForm2()
        {
            InitializeComponent();
        }

        public string NomdelaGalaxie { get; set; }

        private void TxbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxbNom.Text.Length > 0)
                {
                    MessageBox.Show("bravo");
                    PlaneteForm planeteForm = new PlaneteForm();



                    planeteForm.TxbGalaxie.Text = TxbNom.Text;


                    planeteForm.TxbDiamètre.Text = TxbNom.Text;
                   



                }
                else
                {

                    throw new ExceptionVide("Le nom de la nouvelle galaxie est obligatoire");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


        public class ExceptionVide : Exception
        {
            public ExceptionVide(string message) : base(message)
            {
                MessageBox.Show(message);
                return;
            }
        }
    }
}
