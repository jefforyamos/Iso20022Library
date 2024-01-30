﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope42.  ISO2002 ID# _Q-GTZ5S8EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
public partial record ModificationScope42
{
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    /// <summary>
    /// Detailed information about the investment fund or security associated to the account.
    /// </summary>
    public required FinancialInstrument87 FinancialInstrumentDetails { get; init; } 
    
    #nullable disable
}
