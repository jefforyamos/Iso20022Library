﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancelledStatusReason4Code.  ISO2002 ID# _a0yWRtp-Ed-ak6NoX_4Aeg_1964640600.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0yWRtp-Ed-ak6NoX_4Aeg_1964640600")]
[Description(@"Specifies the underlying reason for the cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
public enum CancelledStatusReason4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByYourself".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0yWR9p-Ed-ak6NoX_4Aeg_1964640836")]
    [Description(@"??")]
    CancelledByYourself,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledBySystem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a0yWSNp-Ed-ak6NoX_4Aeg_1964640860")]
    [Description(@"??")]
    CancelledBySystem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledByAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HQNp-Ed-ak6NoX_4Aeg_1964640877")]
    [Description(@"??")]
    CancelledByAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndOfLife".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HQdp-Ed-ak6NoX_4Aeg_1964640921")]
    [Description(@"??")]
    EndOfLife,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledDueToTransformation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HQtp-Ed-ak6NoX_4Aeg_1964640990")]
    [Description(@"??")]
    CancelledDueToTransformation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledSplitPartialSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HQ9p-Ed-ak6NoX_4Aeg_1964641263")]
    [Description(@"??")]
    CancelledSplitPartialSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CancelledDueToCorporateAction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HRNp-Ed-ak6NoX_4Aeg_1964641265")]
    [Description(@"??")]
    CancelledDueToCorporateAction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesNoLongerEligible".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a08HRdp-Ed-ak6NoX_4Aeg_1964641298")]
    [Description(@"??")]
    SecuritiesNoLongerEligible,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancelledStatusReason4CodeMetadataExtensions
{
    private static readonly CancelledStatusReason4CodeDropdownSource _dropdownSource = new CancelledStatusReason4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancelledStatusReason4CodeDropdownRow GetMetadata(this CancelledStatusReason4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

