﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItemAllowanceCharge2.  ISO2002 ID# _b2YbYcNUEeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pricing component, such as a service, promotion, allowance or charge, for this line item.
/// </summary>
public partial record LineItemAllowanceCharge2
{
    #nullable enable
    
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    public IsoYesNoIndicator? ChargeIndicator { get; init; } 
    /// <summary>
    /// Actual monetary value of this allowance charge.
    /// </summary>
    public IsoCurrencyAndAmount? ActualAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity on which this allowance charge is based.
    /// </summary>
    public Quantity10? BasisQuantity { get; init; } 
    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    public IsoPercentageRate? CalculationPercent { get; init; } 
    /// <summary>
    /// Specifies the order in which the allowance or charge is applied.
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Reason, expressed as text, for this allowance charge.
    /// </summary>
    public IDiscountOrChargeType1Choice? Reason { get; init; } 
    
    #nullable disable
}
