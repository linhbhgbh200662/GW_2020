using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GCH1006_Lession09
{
	internal class Admin
	{
		public int Id { get; }
		public string Name { get; set; }

		private Admin(int id)
		{
			this.Id = id;
		}  // prevent creating new objects using the constructor

		private static Admin instance;

		public static Admin Instance
		{
			get {
				if (instance == null)
				{
					instance = new Admin(101);
				}
				return instance;
			}
			private set {instance = value;}
		}

	}
}
