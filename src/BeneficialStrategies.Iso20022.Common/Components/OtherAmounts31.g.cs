﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmounts31.  ISO2002 ID# _ugYp8Tp8EeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
public partial record OtherAmounts31
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection44? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public AmountAndDirection44? ChargesFees { get; init; } 
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    public AmountAndDirection44? CountryNationalFederalTax { get; init; } 
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    public AmountAndDirection44? TradeAmount { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public AmountAndDirection44? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    public AmountAndDirection44? IssueDiscountAllowance { get; init; } 
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    public AmountAndDirection44? PaymentLevyTax { get; init; } 
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    public AmountAndDirection44? LocalTax { get; init; } 
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    public AmountAndDirection44? LocalBrokerCommission { get; init; } 
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    public AmountAndDirection44? Margin { get; init; } 
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    public AmountAndDirection44? Other { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    public AmountAndDirection44? RegulatoryAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    public AmountAndDirection44? ShippingAmount { get; init; } 
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    public AmountAndDirection44? SpecialConcession { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public AmountAndDirection44? StampDuty { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    public AmountAndDirection44? StockExchangeTax { get; init; } 
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    public AmountAndDirection44? TransferTax { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public AmountAndDirection44? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    public AmountAndDirection44? ValueAddedTax { get; init; } 
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    public AmountAndDirection44? WithholdingTax { get; init; } 
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    public AmountAndDirection44? NetGainLoss { get; init; } 
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    public AmountAndDirection44? ConsumptionTax { get; init; } 
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    public AmountAndDirection44? AccruedCapitalisationAmount { get; init; } 
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    public AmountAndDirection44? BookValue { get; init; } 
    
    #nullable disable
}
