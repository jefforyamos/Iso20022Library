﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionTotalsSet1.  ISO2002 ID# _93n5UNxfEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the Sale to POI Reconciliation processing.
/// </summary>
public partial record TransactionTotalsSet1
{
    #nullable enable
    
    /// <summary>
    /// Type of payment instrument.
    /// </summary>
    public required PaymentInstrumentType1Code PaymentInstrumentType { get; init; } 
    /// <summary>
    /// Identification of an Acquirer.
    /// </summary>
    public IsoMax35Text? AcquirerIdentification { get; init; } 
    /// <summary>
    /// Identifier of a host reconciliation period: acquirer for a payment or server for loyalty.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Identifier of a reconciliation period on the sale system.
    /// </summary>
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    /// <summary>
    /// Brand of payment card or loyalty system.
    /// </summary>
    public IsoMax35Text? Brand { get; init; } 
    /// <summary>
    /// Identifier of the POI system performing a reconciliation.
    /// </summary>
    public IsoMax35Text? POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    public IsoMax35Text? SaleIdentification { get; init; } 
    /// <summary>
    /// Identification of the cashier who carried out the transactions.
    /// </summary>
    public IsoMax35Text? CashierIdentification { get; init; } 
    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    public Organisation26[] SponsoredMerchant { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Payment Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    public required TransactionTotals8 TransactionTotal { get; init; } 
    /// <summary>
    /// Loyalty Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    public LoyaltyTransactionTotals1[] LoyaltyTransactionTotal { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
