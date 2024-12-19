// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Output parameters for the <see cref="OnLoginStatusChangedCallback" /> Function.
	/// </summary>
	public struct LoginStatusChangedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="AuthInterface.AddNotifyLoginStatusChanged" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Epic Account ID of the local user whose status has changed
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The status prior to the change
		/// </summary>
		public LoginStatus PrevStatus { get; set; }

		/// <summary>
		/// The status at the time of the notification
		/// </summary>
		public LoginStatus CurrentStatus { get; set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ref LoginStatusChangedCallbackInfoInternal other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			PrevStatus = other.PrevStatus;
			CurrentStatus = other.CurrentStatus;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, System.IDisposable
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private LoginStatus m_PrevStatus;
		private LoginStatus m_CurrentStatus;

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

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public LoginStatus PrevStatus
		{
			get
			{
				return m_PrevStatus;
			}

			set
			{
				m_PrevStatus = value;
			}
		}

		public LoginStatus CurrentStatus
		{
			get
			{
				return m_CurrentStatus;
			}

			set
			{
				m_CurrentStatus = value;
			}
		}

		public void Set(ref LoginStatusChangedCallbackInfo other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			PrevStatus = other.PrevStatus;
			CurrentStatus = other.CurrentStatus;
		}

		public void Set(ref LoginStatusChangedCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				PrevStatus = other.Value.PrevStatus;
				CurrentStatus = other.Value.CurrentStatus;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LocalUserId);
		}

		public void Get(out LoginStatusChangedCallbackInfo output)
		{
			output = new LoginStatusChangedCallbackInfo();
			output.Set(ref this);
		}
	}
}