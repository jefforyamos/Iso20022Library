﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMInquiryRequest2.  ISO2002 ID# _VMLYsa4VEeW_TaP-ygI0SQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of an inquiry from an ATM.
/// </summary>
public partial record ATMInquiryRequest2
{
    #nullable enable
    
    /// <summary>
    /// Environment in which the inquiry is performed.
    /// </summary>
    public required ATMEnvironment14 Environment { get; init; } 
    /// <summary>
    /// Context in which the inquiry is performed.
    /// </summary>
    public required ATMContext14 Context { get; init; } 
    /// <summary>
    /// Inquiry information for the transaction.
    /// </summary>
    public required ATMTransaction29 Transaction { get; init; } 
    
    #nullable disable
}
