// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatServer
{
	/// <summary>
	/// Callback issued when an action must be applied to a connected client.
	/// This callback is always issued from within <see cref="Platform.PlatformInterface.Tick" /> on its calling thread.
	/// </summary>
	public delegate void OnClientActionRequiredCallback(AntiCheatCommon.OnClientActionRequiredCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnClientActionRequiredCallbackInternal(System.IntPtr data);
}