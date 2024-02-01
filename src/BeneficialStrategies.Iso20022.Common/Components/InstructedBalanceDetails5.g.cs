﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalanceDetails5.  ISO2002 ID# _lHIu_Tq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
public partial record InstructedBalanceDetails5
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    public InstructedCorporateActionOption6[] OptionDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
