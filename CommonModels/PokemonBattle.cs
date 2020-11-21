using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
	/// <summary>
	/// ポケモンーバトル関連エンティティ
	/// </summary>
	public class PokemonBattle
	{
		public int Id { get; set; }
		public int PokemonId { get; set; }
		public Pokemon Pokemon { get; set; }
		public int BattleId { get; set; }
		public Battle Battle { get; set; }
	}
}
