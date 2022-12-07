using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AstronomieForm
{
    public class Planete
    {
		#region Attributs
		private string _nom;
		private float _masse;
		private float _diametre;
        #endregion

        #region Accesseurs
        public float Diametre
        {
            get { return _diametre; }
            private set { _diametre = value; }
        }
        public float Masse
        {
            get { return _masse; }
            private set { _masse = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        #endregion

        #region Constructeurs
        public Planete()
        {

        }

        public Planete(string name) : this()
        {
            Nom = name;
        }

        public Planete(string name, float diam) : this(name)
        {
            Diametre = diam;
        }

        public Planete(string nom, float masse, float diametre) : this(nom, masse)
        {
            Masse = masse;
        }

        #endregion

        #region Méthodes publiques
        public string Description()
        {
            return $"Je suis la planète {Nom} de masse {Masse} relative par rapport à la terre.";
            //return string.Format("Je suis la planète {0} de masse {1} relative par rapport à la terre.", Nom, Masse);
        }
        #endregion


    }
}
