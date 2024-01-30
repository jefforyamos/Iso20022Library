﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMContext6.  ISO2002 ID# _RGIdUYqyEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the inquiry is performed.
/// </summary>
public partial record ATMContext6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the service is performed.
    /// </summary>
    public IsoMax35Text? SessionReference { get; init; } 
    /// <summary>
    /// Withdrawal service provided by the ATM inside the session.
    /// </summary>
    public required ATMService6 Service { get; init; } 
    
    #nullable disable
}
