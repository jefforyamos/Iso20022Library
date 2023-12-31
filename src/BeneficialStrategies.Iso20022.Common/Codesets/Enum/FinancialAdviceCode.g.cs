﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialAdviceCode.  ISO2002 ID# _an-pVNp-Ed-ak6NoX_4Aeg_610878701.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if advice has been received from an independent financial advisor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_an-pVNp-Ed-ak6NoX_4Aeg_610878701")]
[Description(@"Specifies if advice has been received from an independent financial advisor.")]
[Derivations(typeof(FinancialAdvice1Code))]
// External derivations that should be provided by the proper interface are: 
public enum FinancialAdviceCode
{
    /// <summary>
    /// Advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_an-pVdp-Ed-ak6NoX_4Aeg_610878726")]
    [Description(@"Advice has been received from an independent financial advisor.")]
    Received,
    
    /// <summary>
    /// Advice has not been received from an independent financial advisor.
    /// Encoded/decoded by serializers as "NREC".
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_an-pVtp-Ed-ak6NoX_4Aeg_610878727")]
    [Description(@"Advice has not been received from an independent financial advisor.")]
    NotReceived,
    
    /// <summary>
    /// It is not known whether or not advice has been received from an independent financial advisor.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_an-pV9p-Ed-ak6NoX_4Aeg_610878743")]
    [Description(@"It is not known whether or not advice has been received from an independent financial advisor.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialAdviceCodeMetadataExtensions
{
    private static readonly FinancialAdviceCodeDropdownSource _dropdownSource = new FinancialAdviceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialAdviceCodeDropdownRow GetMetadata(this FinancialAdviceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


