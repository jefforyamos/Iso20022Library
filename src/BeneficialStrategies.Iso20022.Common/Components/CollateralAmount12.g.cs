﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAmount12.  ISO2002 ID# _gX5CYMLYEei34K_Q744LyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deal amount details.
/// </summary>
public partial record CollateralAmount12
{
    #nullable enable
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    public AmountAndDirection49? Transaction { get; init; } 
    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    public AmountAndDirection49? Termination { get; init; } 
    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    public AmountAndDirection49? Accrued { get; init; } 
    /// <summary>
    /// Specifies whether the interest calculation method is simple or compounding.
    /// </summary>
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; init; } 
    /// <summary>
    /// Specifies when the accrued interest is paid.
    /// </summary>
    public Frequency38Choice_? PaymentFrequency { get; init; } 
    /// <summary>
    /// Number of days after the accrual payment is due.
    /// </summary>
    public IsoMax3NumericText? InterestPaymentDelay { get; init; } 
    /// <summary>
    /// Value of collateral offered or sought. 
    /// </summary>
    public AmountAndDirection49? ValueSought { get; init; } 
    
    #nullable disable
}
