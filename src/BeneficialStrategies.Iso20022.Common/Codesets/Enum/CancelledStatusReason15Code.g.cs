﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason15Code.  ISO2002 ID# _hb8U8ZHsEeWL7bXuV2k5pg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hb8U8ZHsEeWL7bXuV2k5pg")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason15Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByYourself".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_l1VXEZHsEeWL7bXuV2k5pg")]
    [Description(@"??")]
    CancelledByYourself,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mcSCUpHsEeWL7bXuV2k5pg")]
    [Description(@"??")]
    CancelledByAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason15CodeMetadataExtensions
{
    private static readonly CancelledStatusReason15CodeDropdownSource _dropdownSource = new CancelledStatusReason15CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason15CodeDropdownRow GetMetadata(this CancelledStatusReason15Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


