// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="LobbyInterface.JoinLobbyById" /> function.
	/// </summary>
	public struct JoinLobbyByIdCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.JoinLobbyById" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The ID of the lobby
		/// </summary>
		public Utf8String LobbyId { get; set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(ref JoinLobbyByIdCallbackInfoInternal other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			LobbyId = other.LobbyId;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct JoinLobbyByIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyByIdCallbackInfo>, ISettable<JoinLobbyByIdCallbackInfo>, System.IDisposable
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LobbyId;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}

			set
			{
				m_ResultCode = value;
			}
		}

		public object ClientData
		{
			get
			{
				object value;
				Helper.Get(m_ClientData, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ClientData);
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public Utf8String LobbyId
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LobbyId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LobbyId);
			}
		}

		public void Set(ref JoinLobbyByIdCallbackInfo other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			LobbyId = other.LobbyId;
		}

		public void Set(ref JoinLobbyByIdCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LobbyId = other.Value.LobbyId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LobbyId);
		}

		public void Get(out JoinLobbyByIdCallbackInfo output)
		{
			output = new JoinLobbyByIdCallbackInfo();
			output.Set(ref this);
		}
	}
}