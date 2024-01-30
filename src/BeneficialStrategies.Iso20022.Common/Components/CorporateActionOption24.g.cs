﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption24.  ISO2002 ID# _x4ldAezdEd-Z2q4-Bbm3ZA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption24
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IOptionNumber1Choice OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption3Choice OptionType { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption19? SecuritiesMovementDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    public CashOption5? CashMovementDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
