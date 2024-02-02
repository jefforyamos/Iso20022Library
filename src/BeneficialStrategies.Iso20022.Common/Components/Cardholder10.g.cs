﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cardholder10.  ISO2002 ID# _pJM3QZXsEeWMQt4mOczoDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
[DataContract]
[XmlType]
public partial record Cardholder10
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [DataMember]
    public PersonIdentification11? Identification { get; init; } 
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [DataMember]
    public IsoMax45Text? Name { get; init; } 
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [DataMember]
    public LanguageCode? Language { get; init; } 
    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [DataMember]
    public PostalAddress18? BillingAddress { get; init; } 
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [DataMember]
    public PostalAddress18? ShippingAddress { get; init; } 
    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [DataMember]
    public IsoMax35Text? TripNumber { get; init; } 
    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [DataMember]
    public Vehicle1? Vehicle { get; init; } 
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [DataMember]
    public ValueList<CardholderAuthentication9> Authentication { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [DataMember]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [DataMember]
    public IsoMax70Text? PersonalData { get; init; } 
    
    #nullable disable
}
