﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Demand2.  ISO2002 ID# _-BGHRHltEeG7BsjMvd1mEw_-404786743.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the demand.
/// </summary>
public partial record Demand2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date and time the demand is submitted.
    /// </summary>
    public required IsoISODateTime SubmissionDateTime { get; init; } 
    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    public IsoMax2000Text[] AdditionalInformation { get; init; } = [];
    
    #nullable disable
}
