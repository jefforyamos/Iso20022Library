﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundOrderType10Code.  ISO2002 ID# _bDPyMLszEeiTr4dQrTCaYA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDPyMLszEeiTr4dQrTCaYA")]
[Description(@"Specifies a type of investment fund transaction.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType10Code
{
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_fPfJIbszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription,
    
    /// <summary>
    /// Investment fund order is a dividend reinvestment (only applicable to a subscription).
    /// Encoded/decoded by serializers as "ReinvestmentOfDividend".
    /// </summary>
    [EnumMember(Value = "RDIV")]
    [IsoId("_f00q0bszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a dividend reinvestment (only applicable to a subscription).")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_gs6wcbszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption,
    
    /// <summary>
    /// Investment fund order is a regular savings plan (only applicable to a subscription).
    /// Encoded/decoded by serializers as "RegularSavingsPlan".
    /// </summary>
    [EnumMember(Value = "RGSV")]
    [IsoId("_hNyo4bszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is a regular savings plan (only applicable to a subscription).")]
    RegularSavingsPlan,
    
    /// <summary>
    /// Investment fund order is for a withdrawal investment plan (only applicable to a redemption).
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "WIDP")]
    [IsoId("_hpd4QbszEeiTr4dQrTCaYA")]
    [Description(@"Investment fund order is for a withdrawal investment plan (only applicable to a redemption).")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundOrderType10CodeMetadataExtensions
{
    private static readonly FundOrderType10CodeDropdownSource _dropdownSource = new FundOrderType10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundOrderType10CodeDropdownRow GetMetadata(this FundOrderType10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


