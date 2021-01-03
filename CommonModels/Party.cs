using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

		// リレーションシップ
		public List<PokemonParty> PokemonParties { get; set; }

		public List<Battle> Battles { get; set; }
	}
}
