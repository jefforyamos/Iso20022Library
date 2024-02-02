﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorAuthorisationResponse4.  ISO2002 ID# _crk9kWkgEeSTIuB9A-QJ6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
[DataContract]
[XmlType]
public partial record AcceptorAuthorisationResponse4
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment33 Environment { get; init; } 
    /// <summary>
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction38 Transaction { get; init; } 
    /// <summary>
    /// Authorisation response from the acquirer.
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction39 TransactionResponse { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
