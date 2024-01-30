﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSubBalanceTypeAndQuantityBreakdown3.  ISO2002 ID# _p3f1sTnsEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity breakdown information for a specific securities balance.
/// </summary>
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public required ISecuritiesBalanceType6Choice Type { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    public QuantityBreakdown32? QuantityBreakdown { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
