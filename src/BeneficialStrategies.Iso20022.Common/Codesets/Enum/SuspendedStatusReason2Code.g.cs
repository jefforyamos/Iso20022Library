﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SuspendedStatusReason2Code.  ISO2002 ID# _Vk6_Ktp-Ed-ak6NoX_4Aeg_397035063.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a suspended status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vk6_Ktp-Ed-ak6NoX_4Aeg_397035063")]
[Description(@"Specifies the reason for a suspended status.")]
[DerivedFrom(typeof(SuspendedStatusReasonCode))]
public enum SuspendedStatusReason2Code
{
    /// <summary>
    /// There is a suspension of pricing. The order will stay on the books until the next pricing.
    /// Encoded/decoded by serializers as "PRIC".
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_VlEJENp-Ed-ak6NoX_4Aeg_453368006")]
    [Description(@"There is a suspension of pricing. The order will stay on the books until the next pricing.")]
    PriceSuspension = SuspendedStatusReasonCode.PriceSuspension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is a fund overflow.
    /// Encoded/decoded by serializers as "FLOW".
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_VlEJEdp-Ed-ak6NoX_4Aeg_469993316")]
    [Description(@"There is a fund overflow.")]
    Overflow = SuspendedStatusReasonCode.Overflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another reason for the status suspended.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VlEJEtp-Ed-ak6NoX_4Aeg_100672757")]
    [Description(@"Another reason for the status suspended.")]
    Other = SuspendedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SuspendedStatusReason2CodeMetadataExtensions
{
    private static readonly SuspendedStatusReason2CodeDropdownSource _dropdownSource = new SuspendedStatusReason2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISuspendedStatusReason2CodeDropdownRow GetMetadata(this SuspendedStatusReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


