﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdjustmentTypeCode.  ISO2002 ID# _bnTYU9p-Ed-ak6NoX_4Aeg_-949764455.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnTYU9p-Ed-ak6NoX_4Aeg_-949764455")]
[Description(@"Specifies the type of adjustment.")]
[Derivations(typeof(AdjustmentType2Code))]
public enum AdjustmentTypeCode
{
    /// <summary>
    /// Adjustment is a rebate.
    /// Encoded/decoded by serializers as "REBA".
    /// </summary>
    [EnumMember(Value = "REBA")]
    [IsoId("_bnTYVNp-Ed-ak6NoX_4Aeg_-617298628")]
    [Description(@"Adjustment is a rebate.")]
    Rebate,
    
    /// <summary>
    /// Adjustment is a discount.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_bnTYVdp-Ed-ak6NoX_4Aeg_-578510488")]
    [Description(@"Adjustment is a discount.")]
    Discount,
    
    /// <summary>
    /// Adjustment is a credit note.
    /// Encoded/decoded by serializers as "CREN".
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_bnTYVtp-Ed-ak6NoX_4Aeg_-1523605775")]
    [Description(@"Adjustment is a credit note.")]
    CreditNote,
    
    /// <summary>
    /// Adjustment is a surcharge.
    /// Encoded/decoded by serializers as "SURC".
    /// </summary>
    [EnumMember(Value = "SURC")]
    [IsoId("_bnTYV9p-Ed-ak6NoX_4Aeg_-570641076")]
    [Description(@"Adjustment is a surcharge.")]
    Surcharge,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdjustmentTypeCodeMetadataExtensions
{
    private static readonly AdjustmentTypeCodeDropdownSource _dropdownSource = new AdjustmentTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdjustmentTypeCodeDropdownRow GetMetadata(this AdjustmentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


