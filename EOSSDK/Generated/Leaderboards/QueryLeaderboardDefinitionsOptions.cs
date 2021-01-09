// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Input parameters for the <see cref="LeaderboardsInterface.QueryLeaderboardDefinitions" /> function.
	/// StartTime and EndTime are optional parameters, they can be used to limit the list of definitions
	/// to overlap the time window specified.
	/// </summary>
	public class QueryLeaderboardDefinitionsOptions
	{
		/// <summary>
		/// An optional POSIX timestamp for the leaderboard's start time, or <see cref="LeaderboardsInterface.TimeUndefined" />
		/// </summary>
		public System.DateTimeOffset? StartTime { get; set; }

		/// <summary>
		/// An optional POSIX timestamp for the leaderboard's end time, or <see cref="LeaderboardsInterface.TimeUndefined" />
		/// </summary>
		public System.DateTimeOffset? EndTime { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryLeaderboardDefinitionsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private long m_StartTime;
		private long m_EndTime;

		public System.DateTimeOffset? StartTime
		{
			set
			{
				Helper.TryMarshalSet(ref m_StartTime, value);
			}
		}

		public System.DateTimeOffset? EndTime
		{
			set
			{
				Helper.TryMarshalSet(ref m_EndTime, value);
			}
		}

		public void Set(QueryLeaderboardDefinitionsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LeaderboardsInterface.QueryleaderboarddefinitionsApiLatest;
				StartTime = other.StartTime;
				EndTime = other.EndTime;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryLeaderboardDefinitionsOptions);
		}

		public void Dispose()
		{
		}
	}
}