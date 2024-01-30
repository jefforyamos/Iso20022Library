﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCalculation2.  ISO2002 ID# _-d50FKMOEeCojJW5vEuTEQ_1366752768.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the margin calculation per financial instrument or per currency.
/// </summary>
public partial record MarginCalculation2
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Net total of the transaction exposure of all outstanding deals.
    /// </summary>
    public Amount2? ExposureAmount { get; init; } 
    /// <summary>
    /// Provides the total margin amount.
    /// </summary>
    public required AmountAndDirection20 TotalMarginAmount { get; init; } 
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    public Collateral6? CollateralOnDeposit { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the central counterparty.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    /// <summary>
    /// Provide details on the margin result taking into consideration the total margin amount and the minimum requirements deposit.
    /// </summary>
    public IMarginResult1Choice? MarginResult { get; init; } 
    /// <summary>
    /// Provides margin calculation details such as the initial margin amount, the variation margin amount or other margin type amounts.
    /// </summary>
    public Margin3? MarginTypeAmount { get; init; } 
    
    #nullable disable
}
