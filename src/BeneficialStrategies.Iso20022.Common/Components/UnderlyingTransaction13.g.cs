﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction13.  ISO2002 ID# _j5mP1Tq3EeWZFYSPlduMhw.
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
public partial record UnderlyingTransaction13
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [DataMember]
    public OriginalGroupHeader4? OriginalGroupInformationAndCancellation { get; init; } 
    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [DataMember]
    public ValueList<PaymentTransaction62> TransactionInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
