﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReconciliationCategory2.  ISO2002 ID# _yeZ-MT6CEe2Z1_pdMHu4SA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies categories of statuses of a derivative when there is no reporting requirement for both counterparties.
/// </summary>
public partial record ReconciliationCategory2
{
    #nullable enable
    
    /// <summary>
    /// Indicator of derivative reopening, terminated or cancelled by mistake.
    /// </summary>
    public required IsoYesNoIndicator Revived { get; init; } 
    /// <summary>
    /// Indicator of modification to the terms or details of a previously reported derivative, at a trade or position level, but not a correction of a report.
    /// </summary>
    public required IsoYesNoIndicator FurtherModification { get; init; } 
    
    #nullable disable
}
