﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarketClaimTypeCode.  ISO2002 ID# _dZoAIC2mEeuVt5XRmyhHiA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of market claim in the context of a corporate action distribution event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dZoAIC2mEeuVt5XRmyhHiA")]
[Description(@"Specifies the type of market claim in the context of a corporate action distribution event.")]
[Derivations(typeof(MarketClaimType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MarketClaimTypeCode
{
    /// <summary>
    /// Market claim that has been created due to a pending/failing settlement transaction, to ensure the event proceeds are delivered from the seller to the buyer.
    /// Encoded/decoded by serializers as "MKTC".
    /// </summary>
    [EnumMember(Value = "MKTC")]
    [IsoId("_GjijwC2nEeuVt5XRmyhHiA")]
    [Description(@"Market claim that has been created due to a pending/failing settlement transaction, to ensure the event proceeds are delivered from the seller to the buyer.")]
    MarketClaim,
    
    /// <summary>
    /// Market claim that has been created due to a settled settlement transaction, to ensure the event proceeds are delivered from the buyer to the seller.
    /// Encoded/decoded by serializers as "RVMC".
    /// </summary>
    [EnumMember(Value = "RVMC")]
    [IsoId("_UI-esC2nEeuVt5XRmyhHiA")]
    [Description(@"Market claim that has been created due to a settled settlement transaction, to ensure the event proceeds are delivered from the buyer to the seller.")]
    ReverseMarketClaim,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarketClaimTypeCodeMetadataExtensions
{
    private static readonly MarketClaimTypeCodeDropdownSource _dropdownSource = new MarketClaimTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarketClaimTypeCodeDropdownRow GetMetadata(this MarketClaimTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


