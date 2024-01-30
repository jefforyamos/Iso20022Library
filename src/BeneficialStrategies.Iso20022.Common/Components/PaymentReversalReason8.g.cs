﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentReversalReason8.  ISO2002 ID# _mvoC0bTREeeyuKckOGlwuA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the reversal of the transaction.
/// </summary>
public partial record PaymentReversalReason8
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    public PartyIdentification125? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    public IReversalReason4Choice? Reason { get; init; } 
    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
