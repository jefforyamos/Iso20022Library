﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMInquiryRequest1.  ISO2002 ID# _04cHQIqrEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of an inquiry from an ATM.
/// </summary>
public partial record ATMInquiryRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the inquiry is performed.
    /// </summary>
    public required ATMEnvironment4 Environment { get; init; } 
    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    public required ATMContext5 Context { get; init; } 
    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    public required ATMTransaction6 Transaction { get; init; } 
    
    #nullable disable
}
