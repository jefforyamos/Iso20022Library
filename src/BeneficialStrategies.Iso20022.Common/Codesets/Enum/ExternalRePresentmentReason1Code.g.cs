﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalRePresentmentReason1Code.  ISO2002 ID# _Y-8cBfwLEeGHDMP28rpT3g_-2028738047.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-8cBfwLEeGHDMP28rpT3g_-2028738047")]
[Description(@"Specifies the external representment reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.")]
[DerivedFrom(typeof(ExternalRePresentmentReasonCode))]
public enum ExternalRePresentmentReason1Code
{
    /// <summary>
    /// Amount corrected due to proof of transaction
    /// Encoded/decoded by serializers as "AmountCorrected".
    /// </summary>
    [EnumMember(Value = "AMCR")]
    [IsoId("_uOP6a_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount corrected due to proof of transaction")]
    AmountCorrected,
    
    /// <summary>
    /// Liability Shift to acquirer due to missing card authentication method denied
    /// Encoded/decoded by serializers as "CardAuthenticationLiabilityShiftDenied".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_uOZEUvRYEeuLhpyIdtJzwg")]
    [Description(@"Liability Shift to acquirer due to missing card authentication method denied")]
    CardAuthenticationLiabilityShiftDenied,
    
    /// <summary>
    /// Credit previously issued
    /// Encoded/decoded by serializers as "CreditPreviouslyIssued".
    /// </summary>
    [EnumMember(Value = "CRPI")]
    [IsoId("_uOZEVfRYEeuLhpyIdtJzwg")]
    [Description(@"Credit previously issued")]
    CreditPreviouslyIssued,
    
    /// <summary>
    /// Original transaction was valid
    /// Encoded/decoded by serializers as "OriginalTransactionValid".
    /// </summary>
    [EnumMember(Value = "OTVA")]
    [IsoId("_uOZEWPRYEeuLhpyIdtJzwg")]
    [Description(@"Original transaction was valid")]
    OriginalTransactionValid,
    
    /// <summary>
    /// Liability Shift to acquirer due to missing cardholder verification method denied
    /// Encoded/decoded by serializers as "VerificationLiabilityShiftDenied".
    /// </summary>
    [EnumMember(Value = "VLSD")]
    [IsoId("_uOZEW_RYEeuLhpyIdtJzwg")]
    [Description(@"Liability Shift to acquirer due to missing cardholder verification method denied")]
    VerificationLiabilityShiftDenied,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalRePresentmentReason1CodeMetadataExtensions
{
    private static readonly ExternalRePresentmentReason1CodeDropdownSource _dropdownSource = new ExternalRePresentmentReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalRePresentmentReason1CodeDropdownRow GetMetadata(this ExternalRePresentmentReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


