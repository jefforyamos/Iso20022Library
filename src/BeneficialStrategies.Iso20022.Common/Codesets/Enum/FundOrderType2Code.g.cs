﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType2Code.  ISO2002 ID# _VkUiNtp-Ed-ak6NoX_4Aeg_281815183.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkUiNtp-Ed-ak6NoX_4Aeg_281815183")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BedAndBreakfast".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkUiN9p-Ed-ak6NoX_4Aeg_-1292460159")]
    [Description(@"??")]
    BedAndBreakfast,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkUiONp-Ed-ak6NoX_4Aeg_-1292460158")]
    [Description(@"??")]
    InvestmentPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkeTMNp-Ed-ak6NoX_4Aeg_-1292460140")]
    [Description(@"??")]
    PreAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StaffOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkeTMdp-Ed-ak6NoX_4Aeg_-1292460115")]
    [Description(@"??")]
    StaffOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegularSavingsPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkeTMtp-Ed-ak6NoX_4Aeg_1943568529")]
    [Description(@"??")]
    RegularSavingsPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VkeTM9p-Ed-ak6NoX_4Aeg_1943568564")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType2CodeMetadataExtensions
{
    private static readonly FundOrderType2CodeDropdownSource _dropdownSource = new FundOrderType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType2CodeDropdownRow GetMetadata(this FundOrderType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

