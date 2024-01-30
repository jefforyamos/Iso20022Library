﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BenefitCrystallisationEvent2.  ISO2002 ID# _bWw_QZN4EembCsVG-3f_AA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the realisation of benefits taken from a pension.
/// </summary>
public partial record BenefitCrystallisationEvent2
{
    #nullable enable
    
    /// <summary>
    /// Number of the crystallisation event. In the UK market this could be, for example, BCE5, BE5A or BCE5B.
    /// </summary>
    public IsoMax35Text? EventTypeNumber { get; init; } 
    /// <summary>
    /// Name of the crystallisation event. In the UK market this could be, for example, ‘entitlement to scheme pension’.
    /// </summary>
    public IsoMax35Text? EventTypeName { get; init; } 
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
    /// Indicates whether lifetime allowance protection impacts the benefit crystallisation event.
    /// </summary>
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    /// <summary>
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
