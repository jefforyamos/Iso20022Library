﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalanceDetails8.  ISO2002 ID# _qrHHWc3iEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
public partial record InstructedBalanceDetails8
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    public required IBalanceFormat7Choice TotalInstructedBalance { get; init; } 
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    public InstructedCorporateActionOption9? OptionDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
