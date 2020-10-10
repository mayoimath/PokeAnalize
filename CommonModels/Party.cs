using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
	/// <summary>
	/// パーティモデル
	/// </summary>
	public class Party
	{
		public int Id { get; set; }
		[Required]
		public Pokemon Pokemon1 { get; set; }
		[Required]
		public Pokemon Pokemon2 { get; set; }
		[Required]
		public Pokemon Pokemon3 { get; set; }
		[Required]
		public Pokemon Pokemon4 { get; set; }
		[Required]
		public Pokemon Pokemon5 { get; set; }
		[Required]
		public Pokemon Pokemon6 { get; set; }
	}
}
