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
    /// ??
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_fPfJIbszEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Subscription,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReinvestmentOfDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_f00q0bszEeiTr4dQrTCaYA")]
    [Description(@"??")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Redemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gs6wcbszEeiTr4dQrTCaYA")]
    [Description(@"??")]
    Redemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RegularSavingsPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hNyo4bszEeiTr4dQrTCaYA")]
    [Description(@"??")]
    RegularSavingsPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Withdrawal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_hpd4QbszEeiTr4dQrTCaYA")]
    [Description(@"??")]
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

