﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationResponse6.  ISO2002 ID# _5aXFcap5EeanIZ10Ka8PnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
[DataContract]
[XmlType]
public partial record AcceptorCancellationResponse6
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment65 Environment { get; init; } 
    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction57 Transaction { get; init; } 
    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentTransaction68 TransactionResponse { get; init; } 
    
    #nullable disable
}
