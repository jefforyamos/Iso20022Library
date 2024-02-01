﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionContext2.  ISO2002 ID# _q3WpQHsHEeSR68OJvMfxJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card transaction.
/// </summary>
public partial record CardTransactionContext2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not. 
    /// It correspond to the ISO 8583: 1993 field number 22-6.
    /// </summary>
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not. 
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    /// <summary>
    /// Location category of the place where the transaction is actually performed. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    public LocationCategory2Code? LocationCategory { get; init; } 
    /// <summary>
    /// Human attendance at the terminal location during the transaction. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment2Code? TransactionEnvironment { get; init; } 
    /// <summary>
    /// Indicates the entity hosting the terminal performing the transaction. 
    /// It correspond partially to the ISO 8583: 1993 field number 22-4.
    /// </summary>
    public TransactionEnvironment3Code? HostingCategory { get; init; } 
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system. 
    /// It correspond to the ISO 8583: 1993 field number 22-5.
    /// </summary>
    public TransactionChannel3Code? TransactionChannel { get; init; } 
    /// <summary>
    /// Entry mode of the card data. 
    /// It correspond to the ISO 8583 field number 25 for the version 87 (partially), field number 22-7 for the version 93, and field number 22-1 for the version 2003.
    /// </summary>
    public required CardDataReading2Code CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicator of a card entry mode fall-back. It correspond to the ISO 8583: 2003 field number 22-1.
    /// </summary>
    public CardFallback1Code? FallbackIndicator { get; init; } 
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    public SupportedPaymentOption1Code[] SupportedOption { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data used to assign specific condition such as liability shift or preferential interchange fees.
    /// </summary>
    public CardTransactionCondition1[] SpecialConditions { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates to the issuer the level of risk of the transaction.
    /// </summary>
    public CardTransactionRiskIndicator1[] RiskIndicator { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
