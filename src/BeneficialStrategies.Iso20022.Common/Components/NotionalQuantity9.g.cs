﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotionalQuantity9.  ISO2002 ID# _XES6ISJBEe2zWP9pqvmqdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reference quantity of the transaction and the schedule applicable to the quantity computation.
/// </summary>
public partial record NotionalQuantity9
{
    #nullable enable
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    public IsoLongFraction19DecimalNumber? TotalQuantity { get; init; } 
    /// <summary>
    /// Indicates the unit of measure in which the total notional quantity and notional quantity schedules are expressed.
    /// </summary>
    public UnitOfMeasure8Choice_? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Indicates the schedule or frequency of the derivative transactions.
    /// </summary>
    public QuantityOrTerm1Choice_? Details { get; init; } 
    
    #nullable disable
}
