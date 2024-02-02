﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction9.  ISO2002 ID# _6SZA8TKOEeOqyZqt0rCZLg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction including an authorisation response.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentDataSetTransaction9
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [DataMember]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [DataMember]
    public ValueList<Traceability1> Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment28 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction32 Transaction { get; init; } 
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction24 TransactionResponse { get; init; } 
    
    #nullable disable
}
