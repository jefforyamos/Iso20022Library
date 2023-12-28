﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundTransactionOutType4Code.  ISO2002 ID# _ViYohNp-Ed-ak6NoX_4Aeg_1123962465.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement out of a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViYohNp-Ed-ak6NoX_4Aeg_1123962465")]
[Description(@"Specifies the type of investment fund transaction that results in a cash movement out of a fund.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionOutType4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViYohdp-Ed-ak6NoX_4Aeg_-1882035565")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SwitchOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViYohtp-Ed-ak6NoX_4Aeg_-1812771225")]
    [Description(@"??")]
    SwitchOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InSpecie".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViYoh9p-Ed-ak6NoX_4Aeg_1824710762")]
    [Description(@"??")]
    InSpecie,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViYoiNp-Ed-ak6NoX_4Aeg_1843184237")]
    [Description(@"??")]
    CrossOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Dividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViYoidp-Ed-ak6NoX_4Aeg_1864425612")]
    [Description(@"??")]
    Dividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ViiZgNp-Ed-ak6NoX_4Aeg_1870890259")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundTransactionOutType4CodeMetadataExtensions
{
    private static readonly InvestmentFundTransactionOutType4CodeDropdownSource _dropdownSource = new InvestmentFundTransactionOutType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundTransactionOutType4CodeDropdownRow GetMetadata(this InvestmentFundTransactionOutType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

