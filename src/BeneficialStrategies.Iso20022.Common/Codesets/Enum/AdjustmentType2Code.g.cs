﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdjustmentType2Code.  ISO2002 ID# _bnKOZtp-Ed-ak6NoX_4Aeg_-1989744459.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnKOZtp-Ed-ak6NoX_4Aeg_-1989744459")]
[Description(@"Specifies the type of adjustment.")]
[DerivedFrom(typeof(AdjustmentTypeCode))]
public enum AdjustmentType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Rebate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnKOZ9p-Ed-ak6NoX_4Aeg_-1989744440")]
    [Description(@"??")]
    Rebate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Discount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnTYUNp-Ed-ak6NoX_4Aeg_-1989744416")]
    [Description(@"??")]
    Discount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditNote".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnTYUdp-Ed-ak6NoX_4Aeg_-1989744399")]
    [Description(@"??")]
    CreditNote,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Surcharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bnTYUtp-Ed-ak6NoX_4Aeg_-1488271597")]
    [Description(@"??")]
    Surcharge,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdjustmentType2CodeMetadataExtensions
{
    private static readonly AdjustmentType2CodeDropdownSource _dropdownSource = new AdjustmentType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdjustmentType2CodeDropdownRow GetMetadata(this AdjustmentType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

