﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeConfirmationStatus1Code.  ISO2002 ID# _cU5H8IBCEeSUJZYcWGKkkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of the confirmation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cU5H8IBCEeSUJZYcWGKkkw")]
[Description(@"Identifies the status of the confirmation.")]
[DerivedFrom(typeof(TradeConfirmationStatusCode))]
public enum TradeConfirmationStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AllStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hJ9SEYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    AllStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Confirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hO3nQYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    Confirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disaccord".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hTuSEYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    Disaccord,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EmergencyConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hYigoYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    EmergencyConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mismatched".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hdZLcYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    Mismatched,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SelfConfirmedAndCouterpartyNotConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hijYQYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    SelfConfirmedAndCouterpartyNotConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SelfNotConfirmedAndCouterpartyConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hnzrsYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    SelfNotConfirmedAndCouterpartyConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SelfNotConfirmedAndCouterpartyNotConfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hszgcYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    SelfNotConfirmedAndCouterpartyNotConfirmed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unconfirmed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hxrZYYBFEeSUJZYcWGKkkw")]
    [Description(@"??")]
    Unconfirmed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeConfirmationStatus1CodeMetadataExtensions
{
    private static readonly TradeConfirmationStatus1CodeDropdownSource _dropdownSource = new TradeConfirmationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeConfirmationStatus1CodeDropdownRow GetMetadata(this TradeConfirmationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

