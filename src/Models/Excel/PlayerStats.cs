﻿using System;

namespace CSGO_Demos_Manager.Models.Excel
{
	public class PlayerStats
	{
		public int MatchCount { get; set; }

		public int KillCount { get; set; }

		public int AssistCount { get; set; }

		public int DeathCount { get; set; }

		public decimal KillPerDeath => Math.Round((decimal)KillCount/ DeathCount, 2);

		public int HeadshotCount { get; set; }

		public decimal HeadshotPercent => HeadshotCount == 0 ? 0 : Math.Round((decimal)(KillCount * 100) / HeadshotCount, 2);

		public int RoundCount { get; set; }

		public float Rating { get; set; }

		public int FiveKillCount { get; set; }

		public int FourKillCount { get; set; }

		public int ThreeKillCount { get; set; }

		public int TwoKillCount { get; set; }

		public int OneKillCount { get; set; }

		public int TeamKillCount { get; set; }

		public int JumpKillCount { get; set; }

		public int CrouchKillCount { get; set; }

		public int BombPlantedCount { get; set; }

		public int BombDefusedCount { get; set; }

		public int BombExplodedCount { get; set; }

		public int MvpCount { get; set; }

		public int ScoreCount { get; set; }

		public int ClutchCount { get; set; }

		public int ClutchLostCount { get; set; }

		public int Clutch1V1Count { get; set; }

		public int Clutch1V2Count { get; set; }

		public int Clutch1V3Count { get; set; }

		public int Clutch1V4Count { get; set; }

		public int Clutch1V5Count { get; set; }

		public int EntryKillCount { get; set; }

		public int EntryKillWinCount { get; set; }

		public int EntryKillLossCount { get; set; }

		public decimal EntryKillWinPercent => EntryKillCount == 0 ? 0 : Math.Round((decimal)(EntryKillWinCount * 100) / EntryKillCount, 2);

		public int OpenKillCount { get; set; }

		public int OpenKillWinCount { get; set; }

		public int OpenKillLossCount { get; set; }

		public decimal OpenKillWinPercent => OpenKillCount == 0 ? 0 : Math.Round((decimal)(OpenKillWinCount * 100) / OpenKillCount, 2);

		public decimal KillPerRound => Math.Round((decimal)KillCount / RoundCount, 2);

		public decimal AssistPerRound => Math.Round((decimal)AssistCount / RoundCount, 2);

		public decimal DeathPerRound => Math.Round((decimal)DeathCount / RoundCount, 2);

		public decimal AverageDamagePerRound => Math.Round((decimal)DamageHealthCount / RoundCount, 2);

		public int DamageHealthCount { get; set; }

		public int DamageArmorCount { get; set; }

		public int FlashbangThrowedCount { get; set; }

		public int SmokeThrowedCount { get; set; }

		public int HeGrenadeThrowedCount { get; set; }

		public int DecoyThrowedCount { get; set; }

		public int MolotovThrowedCount { get; set; }

		public int IncendiaryThrowedCount { get; set; }

		public int RankMax { get; set; }

		public bool IsVacBanned { get; set; }

		public bool IsOverwatchBanned { get; set; }
	}
}