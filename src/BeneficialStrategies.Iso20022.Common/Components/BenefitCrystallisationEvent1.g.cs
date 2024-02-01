﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BenefitCrystallisationEvent1.  ISO2002 ID# _N2Aj4LToEeiWMOV-LTfmAw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the realisation of benefits taken from a pension.
/// </summary>
public partial record BenefitCrystallisationEvent1
{
    #nullable enable
    
    /// <summary>
    /// Type of crystallisation event.
    /// </summary>
    public DrawdownEventType1Choice_? EventType { get; init; } 
    /// <summary>
    /// Number of the crystallisation event.
    /// </summary>
    public IsoMax35Text? EventNumber { get; init; } 
    /// <summary>
    /// Date on which the crystallisation event was triggered. 
    /// </summary>
    public IsoISODate? EventDate { get; init; } 
    /// <summary>
    /// Amount of the crystallisation event.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; init; } 
    /// <summary>
    /// Percentage of allowance used for the benefit crystallisation event.
    /// </summary>
    public IsoPercentageRate? PercentageOfAllowance { get; init; } 
    /// <summary>
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    public AdditionalInformation15[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
