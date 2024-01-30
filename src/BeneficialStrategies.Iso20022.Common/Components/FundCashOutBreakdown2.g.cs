﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundCashOutBreakdown2.  ISO2002 ID# _SjDJlNp-Ed-ak6NoX_4Aeg_-2020690769.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
public partial record FundCashOutBreakdown2
{
    #nullable enable
    
    /// <summary>
    /// Amount of cash flow out, expressed as an amount of money.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Amount of the cash flow out, expressed as a number of units.
    /// </summary>
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the cash flow is an item that did not appear on the previously sent report, eg, because it was received close to cut-off time.
    /// </summary>
    public IsoYesNoIndicator? NewAmountIndicator { get; init; } 
    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    public required InvestmentFundTransactionOutType1Code InvestmentFundTransactionOutType { get; init; } 
    /// <summary>
    /// Breakdown of the cash movements out of a fund by transaction type, eg, redemption, switch-out.
    /// </summary>
    public required IsoExtended350Code ExtendedInvestmentFundTransactionOutType { get; init; } 
    /// <summary>
    /// Breakdown of the cash movements into a fund by order type, eg, order by quantity of units or amount of money.
    /// </summary>
    public required OrderQuantityType2Code OriginalOrderQuantityType { get; init; } 
    /// <summary>
    /// Breakdown of the cash movements into a fund by transaction type, eg, subscription, switch-in.
    /// </summary>
    public required IsoExtended350Code ExtendedOriginalOrderQuantityType { get; init; } 
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    public Charge16? ChargeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the commission applied to an order, eg, back-end or front-end commission.
    /// </summary>
    public Commission9? CommissionDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
