﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType8Code.  ISO2002 ID# _y8_NwEcuEeam48hW0M8V2Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y8_NwEcuEeam48hW0M8V2Q")]
[Description(@"Specifies the category of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType8Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BedAndBreakfast".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3gJ28UcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    BedAndBreakfast,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvestmentPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4NYJUUcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    InvestmentPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PreAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4wpOcUcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    PreAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegularSavingsPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5Pu-MUcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    RegularSavingsPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegularSavingsPlanUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5c-I8UcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    RegularSavingsPlanUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReinvestmentOfDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6Bkq0UcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StaffOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6fxpwUcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    StaffOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7D7fsUcuEeam48hW0M8V2Q")]
    [Description(@"??")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType8CodeMetadataExtensions
{
    private static readonly FundOrderType8CodeDropdownSource _dropdownSource = new FundOrderType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType8CodeDropdownRow GetMetadata(this FundOrderType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

