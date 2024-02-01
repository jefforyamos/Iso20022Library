﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SegregatedIndependentAmountDispute1.  ISO2002 ID# _Ulb4E9p-Ed-ak6NoX_4Aeg_1239056055.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for the segregated independent amount, the dispute details like the dispute amount or the dispute date and the resolution type details.
/// </summary>
public partial record SegregatedIndependentAmountDispute1
{
    #nullable enable
    
    /// <summary>
    /// Details of the disputed instruction.
    /// </summary>
    public required Dispute1 DisputeDetails { get; init; } 
    /// <summary>
    /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    public DisputeResolutionType1Choice_[] DisputeResolutionType1Choice { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
