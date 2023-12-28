﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType3Code.  ISO2002 ID# _atCvhdp-Ed-ak6NoX_4Aeg_1398779632.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atCvhdp-Ed-ak6NoX_4Aeg_1398779632")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BedAndBreakfast".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atCvhtp-Ed-ak6NoX_4Aeg_233028148")]
    [Description(@"??")]
    BedAndBreakfast,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atCvh9p-Ed-ak6NoX_4Aeg_233028173")]
    [Description(@"??")]
    InvestmentPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atCviNp-Ed-ak6NoX_4Aeg_233028190")]
    [Description(@"??")]
    PreAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StaffOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atL5cNp-Ed-ak6NoX_4Aeg_233028208")]
    [Description(@"??")]
    StaffOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegularSavingsPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atL5cdp-Ed-ak6NoX_4Aeg_233028243")]
    [Description(@"??")]
    RegularSavingsPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReinvestmentOfDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_atL5ctp-Ed-ak6NoX_4Aeg_279205342")]
    [Description(@"??")]
    ReinvestmentOfDividend,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType3CodeMetadataExtensions
{
    private static readonly FundOrderType3CodeDropdownSource _dropdownSource = new FundOrderType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType3CodeDropdownRow GetMetadata(this FundOrderType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

