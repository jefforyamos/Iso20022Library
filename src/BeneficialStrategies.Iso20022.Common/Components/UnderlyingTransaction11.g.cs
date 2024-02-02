﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction11.  ISO2002 ID# _q2Qa6R72EeSxevWRRWxNAg.
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
public partial record UnderlyingTransaction11
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [DataMember]
    public OriginalGroupHeader4? OriginalGroupInformationAndCancellation { get; init; } 
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [DataMember]
    public ValueList<OriginalPaymentInstruction13> OriginalPaymentInformationAndCancellation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
