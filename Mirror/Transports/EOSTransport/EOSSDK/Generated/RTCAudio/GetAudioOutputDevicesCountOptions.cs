// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// Input parameters for the <see cref="RTCAudioInterface.GetAudioOutputDevicesCount" /> function.
	/// </summary>
	public struct GetAudioOutputDevicesCountOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetAudioOutputDevicesCountOptionsInternal : ISettable<GetAudioOutputDevicesCountOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref GetAudioOutputDevicesCountOptions other)
		{
			m_ApiVersion = RTCAudioInterface.GetaudiooutputdevicescountApiLatest;
		}

		public void Set(ref GetAudioOutputDevicesCountOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = RTCAudioInterface.GetaudiooutputdevicescountApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}