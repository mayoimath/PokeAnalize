using CommonModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace BattleAnalisys.ViewModels
{
	/// <summary>
	/// 画面に表示する一覧項目
	/// </summary>
	public class BattleHistoryViewModel : IDisposable
	{
		#region field
		ReactiveProperty<Party> MyParty { get; } = new ReactiveProperty<Party>();
		#endregion

		#region property
		private CompositeDisposable Disposables { get; } = new CompositeDisposable();
		public ReactiveProperty<int> No { get; } = new ReactiveProperty<int>();
		public ReactiveProperty<int?> Ranking { get; } = new ReactiveProperty<int?>();
		public ReactiveProperty<string> MyFirstElection { get; } = new ReactiveProperty<string>();
		public ReactiveProperty<string> MySecondElection { get; } = new ReactiveProperty<string>();
		public ReactiveProperty<string> MyThirdElection { get; } = new ReactiveProperty<string>();
		public ReadOnlyReactiveCollection<Pokemon> EnemysParty { get; }
		public ReactiveProperty<int> EnemysFirstElection { get; } = new ReactiveProperty<int>();
		public ReactiveProperty<int?> EnemysSecondElection { get; } = new ReactiveProperty<int?>();
		public ReactiveProperty<int?> EnemysThirdElection { get; } = new ReactiveProperty<int?>();
		public ReactiveProperty<bool?> Win { get; } = new ReactiveProperty<bool?>();
		public ReactiveProperty<DateTime?> Date { get; } = new ReactiveProperty<DateTime?>();
		#endregion

		#region constructor
		public BattleHistoryViewModel(Battle model)
		{
			this.Ranking = model.ToReactivePropertyAsSynchronized(x => x.Ranking).AddTo(this.Disposables);

			this.MyParty = model.ToReactivePropertyAsSynchronized(x => x.MyParty).AddTo(this.Disposables);
			this.MyFirstElection = model.ToReactivePropertyAsSynchronized(x => x.MyFirstElection,
				convert: i => MyParty.Value.PokemonParties.Count >= i - 1 ? MyParty.Value.PokemonParties[i - 1]?.Pokemon?.Name ?? "" : "",
				convertBack: s => MyParty.Value.PokemonParties.IndexOf(MyParty.Value.PokemonParties.Where(x => x.Pokemon.Name == s).FirstOrDefault()) + 1
				).AddTo(this.Disposables);
			this.MySecondElection = model.ToReactivePropertyAsSynchronized(x => x.MySecondElection,
				convert: i => MyParty.Value.PokemonParties.Count >= i - 1 ? MyParty.Value.PokemonParties[i - 1]?.Pokemon?.Name ?? "" : "",
				convertBack: s => MyParty.Value.PokemonParties.IndexOf(MyParty.Value.PokemonParties.Where(x => x.Pokemon.Name == s).FirstOrDefault()) + 1
				).AddTo(this.Disposables);
			this.MyThirdElection = model.ToReactivePropertyAsSynchronized(x => x.MyThirdElection,
				convert: i => MyParty.Value.PokemonParties.Count >= i - 1 ? MyParty.Value.PokemonParties[i - 1]?.Pokemon?.Name ?? "" : "",
				convertBack: s => MyParty.Value.PokemonParties.IndexOf(MyParty.Value.PokemonParties.Where(x => x.Pokemon.Name == s).FirstOrDefault()) + 1
				).AddTo(this.Disposables);

			this.EnemysParty = model.PokemonBattles.ToReadOnlyReactiveCollection(x => x.Pokemon);
			this.EnemysFirstElection = model.ToReactivePropertyAsSynchronized(x => x.EnemysFirstElection).AddTo(this.Disposables);
			this.EnemysSecondElection = model.ToReactivePropertyAsSynchronized(x => x.EnemysSecondElection).AddTo(this.Disposables);
			this.EnemysThirdElection = model.ToReactivePropertyAsSynchronized(x => x.EnemysThirdElection).AddTo(this.Disposables);
			this.Win = model.ToReactivePropertyAsSynchronized(x => x.Win).AddTo(this.Disposables);
			this.Date = model.ToReactivePropertyAsSynchronized(x => x.DateTime).AddTo(this.Disposables);
		}

		public void Dispose()
		{
			this.Disposables.Dispose();
		}
		#endregion
	}
}
