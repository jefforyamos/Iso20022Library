﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer36.  ISO2002 ID# _s2M5UZEBEem7fvtoGpNpow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record Transfer36
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public AdditionalReference10? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    public AdditionalReference10? CounterpartyReference { get; init; } 
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    public IDateFormat1Choice? RequestedTransferDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    public IsoISODate? TransferOrderDateForm { get; init; } 
    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    public ITransferReason1Choice? TransferReason { get; init; } 
    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    // public IReadOnlyCollection<HoldingsPlanType1Code> HoldingsPlanType { get; init; }
    /// <summary>
    /// Information related to the financial instrument to be transferred.
    /// </summary>
    public required FinancialInstrument88 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Total quantity of securities to be transferred, expressed as a number of units or a percentage rate.
    /// </summary>
    public required IQuantity42Choice Quantity { get; init; } 
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    public Unit12? UnitsDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    /// <summary>
    /// Value of the security, as booked in the account. Book value is often different from the current market value of the security.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    /// <summary>
    /// Additional specific settlement information for the fund.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    public IChargePaymentMethod1Choice? TransferExpensesPaymentType { get; init; } 
    
    #nullable disable
}
