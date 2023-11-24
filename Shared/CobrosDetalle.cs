using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P2MABB.Shared
{
	public class CobrosDetalle
	{
		[Key]
		public int CobradoDetailId { get; set; }

		public int CobroId { get; set; }

		public int VentaId { get; set; }

		public double montoCobrado { get; set; }

		public bool esCobrado { get; set; } = false;

	}
}
