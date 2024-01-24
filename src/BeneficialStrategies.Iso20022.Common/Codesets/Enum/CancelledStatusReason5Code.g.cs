﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason5Code.  ISO2002 ID# _a08HRtp-Ed-ak6NoX_4Aeg_566867564.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a08HRtp-Ed-ak6NoX_4Aeg_566867564")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason5Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as "CANI".
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a08HR9p-Ed-ak6NoX_4Aeg_-2082832297")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a08HSNp-Ed-ak6NoX_4Aeg_1266449994")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason5CodeMetadataExtensions
{
    private static readonly CancelledStatusReason5CodeDropdownSource _dropdownSource = new CancelledStatusReason5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason5CodeDropdownRow GetMetadata(this CancelledStatusReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


