﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentContext28.  ISO2002 ID# _Q3cFUU6VEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment context in which the transaction is performed.
/// </summary>
public partial record PaymentContext28
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    public TransactionChannel5Code? TransactionChannel { get; init; } 
    /// <summary>
    /// Defines the business context of this transaction that could imply specific scheme rules.
    /// </summary>
    public BusinessArea1Code? BusinessArea { get; init; } 
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    /// <summary>
    /// Language used to display messages to the attendant.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    public LanguageCode? AttendantLanguage { get; init; } 
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    public CardDataReading8Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    public CardFallback1Code? FallbackIndicator { get; init; } 
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    public SupportedPaymentOption2Code[] SupportedOption { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
