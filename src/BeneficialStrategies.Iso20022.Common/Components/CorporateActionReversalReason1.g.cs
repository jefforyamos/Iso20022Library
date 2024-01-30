﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionReversalReason1.  ISO2002 ID# _QxDnh9p-Ed-ak6NoX_4Aeg_-2128428826.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the corporate action reversal occurs.
/// </summary>
public partial record CorporateActionReversalReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    public required ICorporateActionReversalReason1Choice Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax256Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
