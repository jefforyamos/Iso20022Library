﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Collateral43.  ISO2002 ID# _otPoFAF1EeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for each collateral account the report summary and the valuation of each piece of collateral.
/// </summary>
public partial record Collateral43
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the collateral account, that is the identification, the type and optionally the name.
    /// </summary>
    public required CollateralAccount3 AccountIdentification { get; init; } 
    /// <summary>
    /// Summary of the collateral valuation.
    /// </summary>
    public required Summary2 ReportSummary { get; init; } 
    /// <summary>
    /// Additional information about the collateral valuation that has been posted.
    /// </summary>
    public CollateralValuation12? CollateralValuation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
