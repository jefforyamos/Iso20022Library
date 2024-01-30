﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentReturnReason1.  ISO2002 ID# _t3s_ElkyEeGeoaLUQk__nA_-1045029043.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the return of the transaction.
/// </summary>
public partial record PaymentReturnReason1
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the return.
    /// </summary>
    public PartyIdentification43? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    public IReturnReason5Choice? Reason { get; init; } 
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
