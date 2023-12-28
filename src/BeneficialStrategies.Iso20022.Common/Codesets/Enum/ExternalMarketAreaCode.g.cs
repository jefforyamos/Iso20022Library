﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMarketAreaCode.  ISO2002 ID# _-ctAF_ouEe2ClqPWkEN24A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external market code, to which the instruction, operation or report relates, in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-ctAF_ouEe2ClqPWkEN24A")]
[Description(@"Specifies the external market code, to which the instruction, operation or report relates, in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalMarketArea1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalMarketAreaCode
{
    /// <summary>
    /// Any market area.
    /// Encoded/decoded by serializers as "ANYY".
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_-ctnEPouEe2ClqPWkEN24A")]
    [Description(@"Any market area.")]
    Any,
    
    /// <summary>
    /// Bank to bank cash movements.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_-ctnFfouEe2ClqPWkEN24A")]
    [Description(@"Bank to bank cash movements.")]
    Cash,
    
    /// <summary>
    /// Collections.
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_-ctnGvouEe2ClqPWkEN24A")]
    [Description(@"Collections.")]
    Collections,
    
    /// <summary>
    /// Precious metals and other commodities such as palm oil.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_-ctnJfouEe2ClqPWkEN24A")]
    [Description(@"Precious metals and other commodities such as palm oil.")]
    Commodities,
    
    /// <summary>
    /// Payment in which one of the parties is not a financial institution.
    /// Encoded/decoded by serializers as "COPA".
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_-ctnEvouEe2ClqPWkEN24A")]
    [Description(@"Payment in which one of the parties is not a financial institution.")]
    CommercialPayments,
    
    /// <summary>
    /// Futures contracts, options, forward contracts, swaps, etc...
    /// Encoded/decoded by serializers as "DERI".
    /// </summary>
    [EnumMember(Value = "DERI")]
    [IsoId("_-ctnF_ouEe2ClqPWkEN24A")]
    [Description(@"Futures contracts, options, forward contracts, swaps, etc...")]
    Derivatives,
    
    /// <summary>
    /// Documentary credits.
    /// Encoded/decoded by serializers as "DOCC".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_-ctnIfouEe2ClqPWkEN24A")]
    [Description(@"Documentary credits.")]
    DocumentaryCredits,
    
    /// <summary>
    /// Foreign exchange.
    /// Encoded/decoded by serializers as "FOEX".
    /// </summary>
    [EnumMember(Value = "FOEX")]
    [IsoId("_-ctnIvouEe2ClqPWkEN24A")]
    [Description(@"Foreign exchange.")]
    ForeignExchange,
    
    /// <summary>
    /// Guarantees.
    /// Encoded/decoded by serializers as "GUAR".
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_-ctnGfouEe2ClqPWkEN24A")]
    [Description(@"Guarantees.")]
    Guarantees,
    
    /// <summary>
    /// Letters of credit.
    /// Encoded/decoded by serializers as "LETT".
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_-ctnH_ouEe2ClqPWkEN24A")]
    [Description(@"Letters of credit.")]
    LettersOfCredit,
    
    /// <summary>
    /// Loans and deposits.
    /// Encoded/decoded by serializers as "LOAN".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_-ctnEfouEe2ClqPWkEN24A")]
    [Description(@"Loans and deposits.")]
    Loans,
    
    /// <summary>
    /// Money markets.
    /// Encoded/decoded by serializers as "MMKT".
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_-ctnIPouEe2ClqPWkEN24A")]
    [Description(@"Money markets.")]
    MoneyMarkets,
    
    /// <summary>
    /// FX forward trade for which only balance is settled.
    /// Encoded/decoded by serializers as "NDLF".
    /// </summary>
    [EnumMember(Value = "NDLF")]
    [IsoId("_-ctnHfouEe2ClqPWkEN24A")]
    [Description(@"FX forward trade for which only balance is settled.")]
    NonDeliverableForward,
    
    /// <summary>
    /// Offshore settlement.
    /// Encoded/decoded by serializers as "OFFS".
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_-ctnFvouEe2ClqPWkEN24A")]
    [Description(@"Offshore settlement.")]
    Offshore,
    
    /// <summary>
    /// Onshore settlement.
    /// Encoded/decoded by serializers as "ONSH".
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_-ctnFPouEe2ClqPWkEN24A")]
    [Description(@"Onshore settlement.")]
    Onshore,
    
    /// <summary>
    /// FX Options, swap options, etc...
    /// Encoded/decoded by serializers as "OPTI".
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_-ctnJPouEe2ClqPWkEN24A")]
    [Description(@"FX Options, swap options, etc...")]
    Options,
    
    /// <summary>
    /// Bonds, equities, futures...
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_-ctnHvouEe2ClqPWkEN24A")]
    [Description(@"Bonds, equities, futures...")]
    Securities,
    
    /// <summary>
    /// Documentary credits, collections, guarantees, letters of credit.
    /// Encoded/decoded by serializers as "TFIN".
    /// </summary>
    [EnumMember(Value = "TFIN")]
    [IsoId("_-ctnHPouEe2ClqPWkEN24A")]
    [Description(@"Documentary credits, collections, guarantees, letters of credit.")]
    TradeFinance,
    
    /// <summary>
    /// Cash management activities.
    /// Encoded/decoded by serializers as "TREA".
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_-ctnE_ouEe2ClqPWkEN24A")]
    [Description(@"Cash management activities.")]
    Treasury,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMarketAreaCodeMetadataExtensions
{
    private static readonly ExternalMarketAreaCodeDropdownSource _dropdownSource = new ExternalMarketAreaCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMarketAreaCodeDropdownRow GetMetadata(this ExternalMarketAreaCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


