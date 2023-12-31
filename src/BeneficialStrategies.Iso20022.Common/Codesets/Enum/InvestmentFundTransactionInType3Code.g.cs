﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentFundTransactionInType3Code.  ISO2002 ID# _ViO3iNp-Ed-ak6NoX_4Aeg_-1481228379.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement into a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViO3iNp-Ed-ak6NoX_4Aeg_-1481228379")]
[Description(@"Specifies the type of investment fund transaction that results in a cash movement into a fund.")]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
public enum InvestmentFundTransactionInType3Code
{
    /// <summary>
    /// Transaction is a subscription to an investment fund.
    /// Encoded/decoded by serializers as "Subscription".
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ViO3idp-Ed-ak6NoX_4Aeg_-936351208")]
    [Description(@"Transaction is a subscription to an investment fund.")]
    Subscription,
    
    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as "SwitchIn".
    /// </summary>
    [EnumMember(Value = "SWII")]
    [IsoId("_ViYogNp-Ed-ak6NoX_4Aeg_-921572438")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchIn,
    
    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as "InSpecie".
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ViYogdp-Ed-ak6NoX_4Aeg_-1939231322")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie,
    
    /// <summary>
    /// Transaction is a cross-in.
    /// Encoded/decoded by serializers as "CrossIn".
    /// </summary>
    [EnumMember(Value = "CROI")]
    [IsoId("_ViYogtp-Ed-ak6NoX_4Aeg_-1929071750")]
    [Description(@"Transaction is a cross-in.")]
    CrossIn,
    
    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ViYog9p-Ed-ak6NoX_4Aeg_-1909676382")]
    [Description(@"Transaction is another type of transaction.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentFundTransactionInType3CodeMetadataExtensions
{
    private static readonly InvestmentFundTransactionInType3CodeDropdownSource _dropdownSource = new InvestmentFundTransactionInType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentFundTransactionInType3CodeDropdownRow GetMetadata(this InvestmentFundTransactionInType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


