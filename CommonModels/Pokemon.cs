using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
	public enum Type
	{
		Normal,
		Water,
		Fire,
		Grass,
		Erectric,
		Ice,
		Fighting,
		Poison,
		Ground,
		Flying,
		Psychic,
		Bug,
		Rock,
		Ghost,
		Dragon,
		Dark,
		Steel,
		Fairy,
	}
	/// <summary>
	/// ポケモンモデル
	/// </summary>
	public class Pokemon
	{
		// ID（登録順に自動インクリメント）
		public int Id { get; set; }
		// 全国図鑑No
		[Column(TypeName ="decimal(3,0)")]
		public int No { get; set; }
		// 名前
		[MaxLength(6)]
		public string Name { get; set; }
		// タイプ
		[Column(TypeName ="nvarchar(8)")]
		public Type? Type { get; set; }
		[Column(TypeName ="nvarchar(8)")]
		public Type? Type2 { get; set; }
		//種族値
		[Column(TypeName ="tinyint")]
		public int? HP { get; set; }
		[Column(TypeName ="tinyint")]
		public int? Attack { get; set; }
		[Column(TypeName ="tinyint")]
		public int? Defense { get; set; }
		[Column(TypeName ="tinyint")]
		public int? SpAtk { get; set; }
		[Column(TypeName ="tinyint")]
		public int? SpDef { get; set; }
		[Column(TypeName ="tinyint")]
		public int? Speed { get; set; }
	}
}
