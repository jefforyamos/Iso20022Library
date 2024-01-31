﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason3Code.  ISO2002 ID# _a0yWQtp-Ed-ak6NoX_4Aeg_2105332425.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0yWQtp-Ed-ak6NoX_4Aeg_2105332425")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason3Code
{
    /// <summary>
    /// Transaction is cancelled by the transfer agent.
    /// Encoded/decoded by serializers as "CNTA".
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_a0yWQ9p-Ed-ak6NoX_4Aeg_2105332427")]
    [Description(@"Transaction is cancelled by the transfer agent.")]
    CancelledByTransferAgent = CancelledStatusReasonCode.CancelledByTransferAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the client.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a0yWRNp-Ed-ak6NoX_4Aeg_2105332450")]
    [Description(@"Transaction is cancelled by the client.")]
    CancelledByClient = CancelledStatusReasonCode.CancelledByClient, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is cancelled by the intermediary.
    /// Encoded/decoded by serializers as "CNIN".
    /// </summary>
    [EnumMember(Value = "CNIN")]
    [IsoId("_a0yWRdp-Ed-ak6NoX_4Aeg_2105332467")]
    [Description(@"Transaction is cancelled by the intermediary.")]
    CancelledByIntermediary = CancelledStatusReasonCode.CancelledByIntermediary, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason3CodeMetadataExtensions
{
    private static readonly CancelledStatusReason3CodeDropdownSource _dropdownSource = new CancelledStatusReason3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason3CodeDropdownRow GetMetadata(this CancelledStatusReason3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


