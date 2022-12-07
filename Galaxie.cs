using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomieForm
{
    public class Galaxie
    {
		#region Attributs
		private string _nom;
		private List<Planete> _lstPlanetes;
		#endregion

		#region Accesseurs
		public List<Planete> lstPlanetes
		{
			get { return _lstPlanetes; }
			set { _lstPlanetes = value; }
		}

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
		#endregion



		#region Méthodes publiques
		public string Description()
		{
			return $"Je suis la galaxie {Nom} et je possède {lstPlanetes.Count} planètes.";

        }
		#endregion

	}
}
