using System;
using System.Collections.Generic;
using ASPNETCOREHomework.Database.Domain;

namespace ASPNETCOREHomework.Database.Mocks
{
	/// <summary>
	/// Mock object for entity's collection of "Notebook"
	/// </summary>
	public static class NotebookMock
	{
		/// <summary>
		/// Getting the collection of the "Notebook" entity.
		/// </summary>
		/// <returns>Entity collection "Notebook".</returns>
		public static IEnumerable<Notebook> GetNotebooks()
		{
			return new List<Notebook>
			{
				new Notebook{ArtCode = "1.0",Description = "1.1",Price = 1,Model = "1.2",Weight = 3.5,Warranty = new DateTime(),Address = "1.3"},
				new Notebook{ArtCode = "2.0",Description = "2.1",Price = 1,Model = "2.2",Weight = 3.5,Warranty = new DateTime(),Address = "2.3"},
				new Notebook{ArtCode = "3.1",Description = "3.2",Price = 1,Model = "3.3",Weight = 3.5,Warranty = new DateTime(),Address = "3.4"},
				new Notebook{ArtCode = "4.1",Description = "4.2",Price = 1,Model = "4.3",Weight = 3.5,Warranty = new DateTime(),Address = "4.4"}
			};
		}
	}
}
