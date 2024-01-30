﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmounts15.  ISO2002 ID# _XdV54f_lEeCozs3wYX8fBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
public partial record OtherAmounts15
{
    #nullable enable
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection9? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public AmountAndDirection9? ChargesFees { get; init; } 
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    public AmountAndDirection9? CountryNationalFederalTax { get; init; } 
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    public AmountAndDirection9? PaymentLevyTax { get; init; } 
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    public AmountAndDirection9? LocalTax { get; init; } 
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    public AmountAndDirection9? Other { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    public AmountAndDirection9? RegulatoryAmount { get; init; } 
    /// <summary>
    /// All costs related to the physical delivery of documents such as stamps, postage, carrier fees, insurances or messenger services.
    /// </summary>
    public AmountAndDirection9? ShippingAmount { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public AmountAndDirection9? StampDuty { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    public AmountAndDirection9? StockExchangeTax { get; init; } 
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    public AmountAndDirection9? TransferTax { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public AmountAndDirection9? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    public AmountAndDirection9? ValueAddedTax { get; init; } 
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    public AmountAndDirection9? WithholdingTax { get; init; } 
    /// <summary>
    /// Amount of consumption tax.
    /// </summary>
    public AmountAndDirection9? ConsumptionTax { get; init; } 
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    public AmountAndDirection9? AccruedCapitalisationAmount { get; init; } 
    
    #nullable disable
}
