using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2MABB.Shared
{
	public class Cobros
	{
		[Key]
		public int CobroId { get; set; }
		public string? Observaciones { get; set; } = string.Empty;

		public DateTime Fecha { get; set; } = DateTime.Now;

		[ForeignKey("CobradoDetailId")]
		public ICollection<CobrosDetalle> CobradoDetail { get; set; } = new List<CobrosDetalle>();
	}
}
