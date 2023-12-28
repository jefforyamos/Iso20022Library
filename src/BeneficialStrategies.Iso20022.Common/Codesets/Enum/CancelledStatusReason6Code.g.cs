﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason6Code.  ISO2002 ID# _a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByYourself".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a1F4Qdp-Ed-ak6NoX_4Aeg_1095310605")]
    [Description(@"??")]
    CancelledByYourself,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByOther".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a1F4Qtp-Ed-ak6NoX_4Aeg_1161803601")]
    [Description(@"??")]
    CancelledByOther,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledBySystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a1F4Q9p-Ed-ak6NoX_4Aeg_1193205425")]
    [Description(@"??")]
    CancelledBySystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a1F4RNp-Ed-ak6NoX_4Aeg_1225528362")]
    [Description(@"??")]
    CancelledByAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a1F4Rdp-Ed-ak6NoX_4Aeg_1272087253")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason6CodeMetadataExtensions
{
    private static readonly CancelledStatusReason6CodeDropdownSource _dropdownSource = new CancelledStatusReason6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason6CodeDropdownRow GetMetadata(this CancelledStatusReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


