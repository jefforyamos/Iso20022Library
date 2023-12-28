﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPurposeAndMarketAreaCode.  ISO2002 ID# _5Wnq8DcdEeOA3chqL9a4Rw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external purpose code for the  the underlying reason for an SSI instruction in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Wnq8DcdEeOA3chqL9a4Rw")]
[Description(@"Specifies the external purpose code for the  the underlying reason for an SSI instruction in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.")]
public enum ExternalPurposeAndMarketAreaCode
{
    /// <summary>
    /// Any market area
    /// Encoded/decoded by serializers as "ANYY".
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_uUMxY_RYEeuLhpyIdtJzwg")]
    [Description(@"Any market area")]
    Any,
    
    /// <summary>
    /// Bank to bank cash movements
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uUMxZvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank to bank cash movements")]
    Cash,
    
    /// <summary>
    /// Collections
    /// Encoded/decoded by serializers as "COLL".
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_uUMxafRYEeuLhpyIdtJzwg")]
    [Description(@"Collections")]
    Collections,
    
    /// <summary>
    /// Precious metals and other commodities such as palm oil
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uUWiYPRYEeuLhpyIdtJzwg")]
    [Description(@"Precious metals and other commodities such as palm oil")]
    Commodities,
    
    /// <summary>
    /// Payment in which one of the parties is not a financial institution
    /// Encoded/decoded by serializers as "COPA".
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_uUWiY_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment in which one of the parties is not a financial institution")]
    CommercialPayments,
    
    /// <summary>
    /// Futures contracts, options, forward contracts, swaps, etc
    /// Encoded/decoded by serializers as "DERI".
    /// </summary>
    [EnumMember(Value = "DERI")]
    [IsoId("_uUgTYPRYEeuLhpyIdtJzwg")]
    [Description(@"Futures contracts, options, forward contracts, swaps, etc")]
    Derivatives,
    
    /// <summary>
    /// Documentary credits
    /// Encoded/decoded by serializers as "DOCC".
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_uUgTY_RYEeuLhpyIdtJzwg")]
    [Description(@"Documentary credits")]
    DocumentaryCredits,
    
    /// <summary>
    /// Foreign Exchange
    /// Encoded/decoded by serializers as "FOEX".
    /// </summary>
    [EnumMember(Value = "FOEX")]
    [IsoId("_uUgTZvRYEeuLhpyIdtJzwg")]
    [Description(@"Foreign Exchange")]
    ForeignExchange,
    
    /// <summary>
    /// Guarantees
    /// Encoded/decoded by serializers as "GUAR".
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_uUgTafRYEeuLhpyIdtJzwg")]
    [Description(@"Guarantees")]
    Guarantees,
    
    /// <summary>
    /// Letters of credit
    /// Encoded/decoded by serializers as "LETT".
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_uUpdUPRYEeuLhpyIdtJzwg")]
    [Description(@"Letters of credit")]
    LettersOfCredit,
    
    /// <summary>
    /// Loans and deposits
    /// Encoded/decoded by serializers as "LOAN".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_uUpdU_RYEeuLhpyIdtJzwg")]
    [Description(@"Loans and deposits")]
    Loans,
    
    /// <summary>
    /// Loans and deposits
    /// Encoded/decoded by serializers as "MMKT".
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_uUpdVvRYEeuLhpyIdtJzwg")]
    [Description(@"Loans and deposits")]
    MoneyMarkets,
    
    /// <summary>
    /// FX forward trade for which only balance is settled
    /// Encoded/decoded by serializers as "NDLF".
    /// </summary>
    [EnumMember(Value = "NDLF")]
    [IsoId("_uUpdWfRYEeuLhpyIdtJzwg")]
    [Description(@"FX forward trade for which only balance is settled")]
    NonDeliverableForward,
    
    /// <summary>
    /// Offshore settlement
    /// Encoded/decoded by serializers as "OFFS".
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_uUpdXPRYEeuLhpyIdtJzwg")]
    [Description(@"Offshore settlement")]
    Offshore,
    
    /// <summary>
    /// Onshore settlement
    /// Encoded/decoded by serializers as "ONSH".
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_uUzOUPRYEeuLhpyIdtJzwg")]
    [Description(@"Onshore settlement")]
    Onshore,
    
    /// <summary>
    /// FX Options, swap options, etc
    /// Encoded/decoded by serializers as "OPTI".
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_uUzOU_RYEeuLhpyIdtJzwg")]
    [Description(@"FX Options, swap options, etc")]
    Options,
    
    /// <summary>
    /// Bonds, equities, futures
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_uUzOVvRYEeuLhpyIdtJzwg")]
    [Description(@"Bonds, equities, futures")]
    Securities,
    
    /// <summary>
    /// Documentary credits, collections, guarantees, letters of credit
    /// Encoded/decoded by serializers as "TFIN".
    /// </summary>
    [EnumMember(Value = "TFIN")]
    [IsoId("_uUzOWfRYEeuLhpyIdtJzwg")]
    [Description(@"Documentary credits, collections, guarantees, letters of credit")]
    TradeFinance,
    
    /// <summary>
    /// Cash management activities
    /// Encoded/decoded by serializers as "TREA".
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_uU8YQPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash management activities")]
    Treasury,
    
    /// <summary>
    /// Relates to Collateral Management
    /// ATTENTION: Name was changed from "COLL" to "COLL2" due to a name clash in the published ISO specification.
    /// During deserialization, you may see some ambiguity between this and <seealso cref="COLL"/>
    /// </summary>
    [EnumMember(Value = "COLL")] // Beware deserialization issues here because of ambiguity
    [IsoId("_uU8YSfRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to Collateral Management")]
    CollateralManagement,
    
    /// <summary>
    /// Relates to Securities Lending
    /// Encoded/decoded by serializers as "SECL".
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_uVGJQPRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to Securities Lending")]
    SecuritiesLending,
    
    /// <summary>
    /// Relates to settlements
    /// Encoded/decoded by serializers as "STMT".
    /// </summary>
    [EnumMember(Value = "STMT")]
    [IsoId("_uVGJQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Relates to settlements")]
    Settlements,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPurposeAndMarketAreaCodeMetadataExtensions
{
    private static readonly ExternalPurposeAndMarketAreaCodeDropdownSource _dropdownSource = new ExternalPurposeAndMarketAreaCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPurposeAndMarketAreaCodeDropdownRow GetMetadata(this ExternalPurposeAndMarketAreaCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

