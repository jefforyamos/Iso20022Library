﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceData2.  ISO2002 ID# _IGnwMTN0Ee2gE4h-lpiUxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the details of the price applicable to the derivative transaction.
/// </summary>
public partial record PriceData2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    public ISecuritiesTransactionPrice17Choice? Price { get; init; } 
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with prices varying throughout the life of the transaction.
    /// </summary>
    public Schedule1? SchedulePeriod { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the unit of measure in which the price is expressed.
    /// </summary>
    public IUnitOfMeasure8Choice? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    public IsoLongFraction19DecimalNumber? PriceMultiplier { get; init; } 
    
    #nullable disable
}
