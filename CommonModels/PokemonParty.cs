using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
	/// <summary>
	/// ポケモン-パーティ関連エンティティ
	/// </summary>
	public class PokemonParty
	{
		public int Id { get; set; }
		public int PokemonId { get; set; }
		public Pokemon Pokemon { get; set; }
		public int PartyId { get; set; }
		public Party Party { get; set; }
	}
}
