﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundTransactionOutType1Code.  ISO2002 ID# _aczUE9p-Ed-ak6NoX_4Aeg_1672602191.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement out of a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aczUE9p-Ed-ak6NoX_4Aeg_1672602191")]
[Description(@"Specifies the type of investment fund transaction that results in a cash movement out of a fund.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionOutType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aczUFNp-Ed-ak6NoX_4Aeg_1717851866")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SwitchOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aczUFdp-Ed-ak6NoX_4Aeg_1717851883")]
    [Description(@"??")]
    SwitchOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InSpecie".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aczUFtp-Ed-ak6NoX_4Aeg_1717851901")]
    [Description(@"??")]
    InSpecie,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aczUF9p-Ed-ak6NoX_4Aeg_1717851902")]
    [Description(@"??")]
    CrossOut,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundTransactionOutType1CodeMetadataExtensions
{
    private static readonly InvestmentFundTransactionOutType1CodeDropdownSource _dropdownSource = new InvestmentFundTransactionOutType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundTransactionOutType1CodeDropdownRow GetMetadata(this InvestmentFundTransactionOutType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

