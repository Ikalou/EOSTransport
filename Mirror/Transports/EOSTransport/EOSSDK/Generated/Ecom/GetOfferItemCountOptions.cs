// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferItemCount" /> function.
	/// </summary>
	public struct GetOfferItemCountOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user who made the initial request for the Catalog Offer through <see cref="EcomInterface.QueryOffers" />
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// An ID that corresponds to a cached Catalog Offer (retrieved by <see cref="EcomInterface.CopyOfferByIndex" />)
		/// </summary>
		public Utf8String OfferId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetOfferItemCountOptionsInternal : ISettable<GetOfferItemCountOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OfferId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String OfferId
		{
			set
			{
				Helper.Set(value, ref m_OfferId);
			}
		}

		public void Set(ref GetOfferItemCountOptions other)
		{
			m_ApiVersion = EcomInterface.GetofferitemcountApiLatest;
			LocalUserId = other.LocalUserId;
			OfferId = other.OfferId;
		}

		public void Set(ref GetOfferItemCountOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = EcomInterface.GetofferitemcountApiLatest;
				LocalUserId = other.Value.LocalUserId;
				OfferId = other.Value.OfferId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_OfferId);
		}
	}
}