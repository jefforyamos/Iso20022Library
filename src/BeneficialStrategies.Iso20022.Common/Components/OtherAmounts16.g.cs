﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmounts16.  ISO2002 ID# _AkJEUNokEeC60axPepSq7g_-185304496.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies other amounts pertaining to the transaction.
/// </summary>
public partial record OtherAmounts16
{
    #nullable enable
    
    /// <summary>
    /// Amount of money paid for the provision of financial services that cannot be categorised by another qualifier.
    /// </summary>
    public AmountAndDirection29? ChargesFees { get; init; } 
    /// <summary>
    /// Amount of country, national or federal tax charged by the jurisdiction in which the account servicer is located.
    /// </summary>
    public AmountAndDirection29? CountryNationalFederalTax { get; init; } 
    /// <summary>
    /// Amount of money paid to an executing broker as a commission.
    /// </summary>
    public AmountAndDirection29? ExecutingBrokerAmount { get; init; } 
    /// <summary>
    /// Amount of money defined as a discount on a new issue or on a tranche of an existing issue.
    /// </summary>
    public AmountAndDirection29? IssueDiscountAllowance { get; init; } 
    /// <summary>
    /// Amount of payment levy tax.
    /// </summary>
    public AmountAndDirection29? PaymentLevyTax { get; init; } 
    /// <summary>
    /// Tax charged by the jurisdiction in which the financial instrument settles.
    /// </summary>
    public AmountAndDirection29? LocalTax { get; init; } 
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    public AmountAndDirection29? LocalBrokerCommission { get; init; } 
    /// <summary>
    /// Amount of money deposited by the trading party in a margin account.
    /// </summary>
    public AmountAndDirection29? Margin { get; init; } 
    /// <summary>
    /// An amount that is not indicated by a known business denomination.
    /// </summary>
    public AmountAndDirection29? Other { get; init; } 
    /// <summary>
    /// Amount of money charged by a regulatory authority, for example, Securities and Exchange fees.
    /// </summary>
    public AmountAndDirection29? RegulatoryAmount { get; init; } 
    /// <summary>
    /// Amount of drawdown or other reduction from or in addition to the deal price.
    /// </summary>
    public AmountAndDirection29? SpecialConcession { get; init; } 
    /// <summary>
    /// Amount of stamp duty.
    /// </summary>
    public AmountAndDirection29? StampDuty { get; init; } 
    /// <summary>
    /// Amount of stock exchange tax.
    /// </summary>
    public AmountAndDirection29? StockExchangeTax { get; init; } 
    /// <summary>
    /// Amount of tax levied on a transfer of ownership of financial instrument.
    /// </summary>
    public AmountAndDirection29? TransferTax { get; init; } 
    /// <summary>
    /// Amount of transaction tax.
    /// </summary>
    public AmountAndDirection29? TransactionTax { get; init; } 
    /// <summary>
    /// Amount of value-added tax.
    /// </summary>
    public AmountAndDirection29? ValueAddedTax { get; init; } 
    /// <summary>
    /// Amount of money that will be withheld by a tax authority.
    /// </summary>
    public AmountAndDirection29? WithholdingTax { get; init; } 
    /// <summary>
    /// Amount representing the difference between the cost and the current price of a security. In the context of securities settlement, it is the amount paid or received when the instructions are netted or paired off.
    /// </summary>
    public AmountAndDirection29? NetGainLoss { get; init; } 
    /// <summary>
    /// A tax on spending on goods and services.
    /// </summary>
    public AmountAndDirection29? ConsumptionTax { get; init; } 
    /// <summary>
    /// Amount of money charged for matching and/or confirmation.
    /// </summary>
    public AmountAndDirection29? MatchingConfirmationFee { get; init; } 
    /// <summary>
    /// Amount following a foreign exchange conversion.
    /// </summary>
    public AmountAndDirection29? ConvertedAmount { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public AmountAndDirection29? OriginalCurrencyAmount { get; init; } 
    /// <summary>
    /// Cost of the securities. May be requested in some countries for tax purposes.
    /// </summary>
    public AmountAndDirection29? BookValue { get; init; } 
    /// <summary>
    /// Amount of unpaid interest (on bonds which have defaulted and have subsequently |restructured), which is capitalized and added to the original principal amount of the bond.
    /// </summary>
    public AmountAndDirection29? AccruedCapitalisationAmount { get; init; } 
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    public AmountAndDirection29? LocalTaxCountrySpecific1 { get; init; } 
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    public AmountAndDirection29? LocalTaxCountrySpecific2 { get; init; } 
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    public AmountAndDirection29? LocalTaxCountrySpecific3 { get; init; } 
    /// <summary>
    /// Local tax as defined by the country in its market practice document.
    /// </summary>
    public AmountAndDirection29? LocalTaxCountrySpecific4 { get; init; } 
    /// <summary>
    /// Amount paid as result of transactions subject to shared brokerage commissions.
    /// </summary>
    public AmountAndDirection29? SharedBrokerageAmount { get; init; } 
    /// <summary>
    /// Indicates the total fees related to the trade, with deduction of rebates (on brokerage, commission or differential) granted by the market member (fee amount with tax excluded).
    /// </summary>
    public AmountAndDirection29? MarketMemberFeeAmount { get; init; } 
    /// <summary>
    /// Specifies that this information is available upon request.
    /// </summary>
    public IsoYesNoIndicator? RemunerationAmountRequest { get; init; } 
    /// <summary>
    /// Specifies the source and amount of any other remuneration received or to be received by the broker in connection with the transaction.
    /// </summary>
    public AmountAndDirection29? RemunerationAmount { get; init; } 
    /// <summary>
    /// Amount to be paid by the lender to the borrower calculated based on the interest rate.
    /// </summary>
    public AmountAndDirection29? BorrowingInterestAmount { get; init; } 
    /// <summary>
    /// Amount to be paid by the Borrower to the Lender for the securities borrowed calculated based on the bond loan rate.
    /// </summary>
    public AmountAndDirection29? BorrowingFee { get; init; } 
    /// <summary>
    /// Net market value of the securities lent used to calculate the collateral amount.
    /// </summary>
    public AmountAndDirection29? NetMarketValue { get; init; } 
    /// <summary>
    /// Remaining nominal value of a security.
    /// </summary>
    public AmountAndDirection29? RemainingFaceValue { get; init; } 
    /// <summary>
    /// Remaining value at which an asset is carried on a balance sheet.
    /// </summary>
    public AmountAndDirection29? RemainingBookValue { get; init; } 
    /// <summary>
    /// Amount of commission paid to a clearing broker.
    /// </summary>
    public AmountAndDirection29? ClearingBrokerCommission { get; init; } 
    /// <summary>
    /// Difference between the deal price and another reference price.
    /// </summary>
    public AmountAndDirection29? DifferenceInPrice { get; init; } 
    /// <summary>
    /// Specifies that the odd-lot differential or equivalent fee has been paid by such customer in connection with the execution of an order for an odd-lot number of shares or units (or principal amount) of a security and the fact that the amount of any such differential or fee will be furnished upon oral or written request.
    /// </summary>
    public IsoYesNoIndicator? OddLotFee { get; init; } 
    
    #nullable disable
}
