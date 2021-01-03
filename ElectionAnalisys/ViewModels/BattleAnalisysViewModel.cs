using System;
using System.Collections.Generic;
using System.Linq;
using CommonModels;
using Microsoft.EntityFrameworkCore;

namespace BattleAnalisys.ViewModels
{
	public class BattleAnalisysViewModel:IDisposable
	{
		#region field

		#endregion

		#region property
		public List<BattleHistoryViewModel> BattleHistoryList { get; set; }
		#endregion

		public BattleAnalisysViewModel()
		{
			using (var context = new PokeAnalizeDbContext())
			{
				this.BattleHistoryList = context.Battles
					.Include(battle=>battle.MyParty).ThenInclude(party=>party.PokemonParties).ThenInclude(pokemonParty=>pokemonParty.Pokemon)
					.Include(battle=>battle.PokemonBattles).ThenInclude(pokemonBattles=>pokemonBattles.Pokemon)
					.Select(x => new BattleHistoryViewModel(x)).ToList();
			}
		}

		public void Dispose()
		{
			//base.di
		}
	}
}
