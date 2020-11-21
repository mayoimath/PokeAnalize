﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
	/// <summary>
	/// 対戦モデル
	/// </summary>
	public class Battle
	{
		public int Id { get; set; }
		// 順位
		public int? Ranking { get; set; }
		// 自分パーティ
		public int MyPartyId { get; set; }
		[ForeignKey(nameof(MyPartyId))]
		public Party MyParty { get; set; }
		// 相手パーティ
		public List<PokemonBattle> PokemonBattles { get; set; }
		// 選出
		public int MyFirstElection { get; set; }
		public int MySecondElection { get; set; }
		public int MyThirdElection { get; set; }
		public int EnemysFirstElection { get; set; }
		public int? EnemysSecondElection { get; set; }
		public int? EnemysThirdElection { get; set; }
		// 勝敗
		public bool? Win { get; set; }
		// 対戦日
		public DateTime? DateTime { get; set; }
	}
}
