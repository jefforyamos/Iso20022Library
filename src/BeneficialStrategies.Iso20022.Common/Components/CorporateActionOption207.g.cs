﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption207.  ISO2002 ID# _p3BXWzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption207
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IOptionNumber1Choice OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption39Choice OptionType { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption86? SecuritiesMovementDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    public CashOption62? CashMovementDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
