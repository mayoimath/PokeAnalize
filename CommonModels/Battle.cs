using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public class Battle : BindableBase
	{
		private int _id;
		public int Id
		{
			get { return _id; }
			set { SetProperty(ref _id, value); }
		}
		// 順位
		private int? _ranking;
		public int? Ranking
		{
			get { return _ranking; }
			set { SetProperty(ref _ranking, value); }
		}
		// 自分パーティ
		public int MyPartyId { get; set; }
		private Party _myParty;
		[ForeignKey(nameof(MyPartyId))]
		public Party MyParty
		{
			get { return _myParty; }
			set { SetProperty(ref _myParty, value); }
		}
		// 相手パーティ
		private ObservableCollection<PokemonBattle> _pokemonBattles;
		public ObservableCollection<PokemonBattle> PokemonBattles
		{
			get { return _pokemonBattles; }
			set { SetProperty(ref _pokemonBattles, value); }
		}
		// 選出
		private int _myFirstElection;
		public int MyFirstElection
		{
			get { return _myFirstElection; }
			set { SetProperty(ref _myFirstElection, value); }
		}
		private int _mySecondElection;
		public int MySecondElection
		{
			get { return _mySecondElection; }
			set { SetProperty(ref _mySecondElection, value); }
		}
		private int _myThirdElection;
		public int MyThirdElection
		{
			get { return _myThirdElection; }
			set { SetProperty(ref _myThirdElection, value); }
		}
		private int _enemysFirstElection;
		public int EnemysFirstElection
		{
			get { return _enemysFirstElection; }
			set { SetProperty(ref _enemysFirstElection, value); }
		}
		private int? _enemysSecondElection;
		public int? EnemysSecondElection
		{
			get { return _enemysSecondElection; }
			set { SetProperty(ref _enemysSecondElection, value); }
		}
		private int? _enemysThirdElection;
		public int? EnemysThirdElection
		{
			get { return _enemysThirdElection; }
			set { SetProperty(ref _enemysThirdElection, value); }
		}
		// 勝敗
		private bool? _win;
		public bool? Win
		{
			get { return _win; }
			set { SetProperty(ref _win, value); }
		}
		// 対戦日
		private DateTime? _dateTime;
		public DateTime? DateTime
		{
			get { return _dateTime; }
			set { SetProperty(ref _dateTime, value); }
		}
	}
}
