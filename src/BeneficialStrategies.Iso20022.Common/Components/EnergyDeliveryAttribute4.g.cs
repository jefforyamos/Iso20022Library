﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnergyDeliveryAttribute4.  ISO2002 ID# _HJBv0YeIEei3PYANOK_QWA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to energy derivatives attributes.
/// </summary>
public partial record EnergyDeliveryAttribute4
{
    #nullable enable
    
    /// <summary>
    /// Time interval for each block or shape.
    /// </summary>
    public IsoISOTime? DeliveryInterval { get; init; } 
    /// <summary>
    /// Definition of delivery start datetime and end datetime.
    /// </summary>
    public DateTimePeriod1? DeliveryPeriod { get; init; } 
    /// <summary>
    /// Start time and end time for each block or shape.
    /// </summary>
    public TimePeriodDetails1? DeliveryTime { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Duration of the delivery period.
    /// </summary>
    public DurationType1Code? Duration { get; init; } 
    /// <summary>
    /// Days of the week of the delivery.
    /// </summary>
    public WeekDay3Code? WeekDay { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Delivery capacity for each delivery interval specified.
    /// </summary>
    public IQuantity46Choice? DeliveryCapacity { get; init; } 
    /// <summary>
    /// Daily or hourly quantity in MWh or kWh/d which corresponds to the underlying commodity.
    /// </summary>
    public IEnergyQuantityUnit1Choice? QuantityUnit { get; init; } 
    /// <summary>
    /// Indicates if applicable the price per quantity per delivery time interval.
    /// </summary>
    public IsoLongFraction21DecimalNumber? PriceTimeIntervalQuantity { get; init; } 
    
    #nullable disable
}
