﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace3.  ISO2002 ID# _R-_aRdp-Ed-ak6NoX_4Aeg_1472551753.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalancePerSafekeepingPlace3
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount[] HoldingValue { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation2[] PriceDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    public SubBalanceInformation2[] BalanceBreakdownDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    public AdditionalBalanceInformation2[] AdditionalBalanceBreakdownDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
