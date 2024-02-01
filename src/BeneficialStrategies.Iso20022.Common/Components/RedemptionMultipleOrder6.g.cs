﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionMultipleOrder6.  ISO2002 ID# _7RE7JTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
public partial record RedemptionMultipleOrder6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    public PlaceOfTradeIdentification1Choice_? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Date and time the order is placed by the investor or its agent.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    public CancellationRight1Choice_? CancellationRight { get; init; } 
    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    public IndividualPerson32[] BeneficiaryDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    public RedemptionOrder14[] IndividualOrderDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction72? BulkCashSettlementDetails { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the multiple order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalSettlementAmount { get; init; } 
    
    #nullable disable
}
