﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundTransaction2.  ISO2002 ID# _VGOQ-tp-Ed-ak6NoX_4Aeg_-1833771297.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
/// </summary>
public partial record InvestmentFundTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    public required ITransactionType1CodeChoice TransactionType { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required ICorporateActionEventType1CodeChoice CorporateActionEventType { get; init; } 
    /// <summary>
    /// Status of an investment fund transaction.
    /// </summary>
    public TransactionStatus1Code? BookingStatus { get; init; } 
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique identifier for an order, as assigned by the sell-side. The identifier must be unique within a single trading day.
    /// </summary>
    public IsoMax35Text? OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    public IsoMax35Text? LegIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for an instance of a leg execution within a switch confirmation.
    /// </summary>
    public IsoMax35Text? LegExecutionIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Indicates whether the cash payment with respect to the executed order is settled.
    /// </summary>
    public required IsoYesNoIndicator SettledTransactionIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the executed order has a registered status on the books of the transfer agent.
    /// </summary>
    public required IsoYesNoIndicator RegisteredTransactionIndicator { get; init; } 
    /// <summary>
    /// Number of investment funds units.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsQuantity { get; init; } 
    /// <summary>
    /// Direction of the transaction being reported, ie, securities are received (credited) or delivered (debited).
    /// </summary>
    public required CreditDebitCode CreditDebit { get; init; } 
    /// <summary>
    /// Transaction being reported is a reversal of previously reported transaction.
    /// </summary>
    public ReversalCode? Reversal { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the debtor expects the amount of money to be available to the creditor.
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public UnitPrice1? PriceDetails { get; init; } 
    
    #nullable disable
}
