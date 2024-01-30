﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PositionSetMetrics12.  ISO2002 ID# _oRNJEc9JEeubvZK8CMH-Eg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets.
/// </summary>
public partial record PositionSetMetrics12
{
    #nullable enable
    
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    public VolumeMetrics6? VolumeMetrics { get; init; } 
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    public IsoPercentageRate? HaircutOrMargin { get; init; } 
    /// <summary>
    /// Quantity of the securities other than bonds.
    /// </summary>
    public IQuantityNominalValue2Choice? QuantityOrNominalAmount { get; init; } 
    
    #nullable disable
}
