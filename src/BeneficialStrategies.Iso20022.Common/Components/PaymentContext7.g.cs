﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentContext7.  ISO2002 ID# _9XFDUTJ1EeOqyZqt0rCZLg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment context in which the transaction is performed.
/// </summary>
[DataContract]
[XmlType]
public partial record PaymentContext7
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    [DataMember]
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [DataMember]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [DataMember]
    public TransactionChannel1Code? TransactionChannel { get; init; } 
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    /// <summary>
    /// Language used to display messages to the attendant.
    /// </summary>
    [DataMember]
    public ISO2ALanguageCode? AttendantLanguage { get; init; } 
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [DataMember]
    public CardDataReading1Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? FallbackIndicator { get; init; } 
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [DataMember]
    public ValueList<SupportedPaymentOption1Code> SupportedOption { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
