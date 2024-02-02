﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction20.  ISO2002 ID# _aG6eD4tvEee-OJ-wXSj3YQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[DataContract]
[XmlType]
public partial record UnderlyingTransaction20
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [DataMember]
    public OriginalGroupHeader10? OriginalGroupInformationAndCancellation { get; init; } 
    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [DataMember]
    public ValueList<PaymentTransaction89> TransactionInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
