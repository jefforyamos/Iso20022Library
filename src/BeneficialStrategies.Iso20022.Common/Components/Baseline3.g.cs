﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Baseline3.  ISO2002 ID# _Sq9IZdp-Ed-ak6NoX_4Aeg_-88106768.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the commercial details of the underlying transaction.
/// </summary>
public partial record Baseline3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the baseline provided by the submitter.
    /// </summary>
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    /// <summary>
    /// Identifies the service requested by the submitter by means of a code.
    /// </summary>
    public required TradeFinanceService2Code ServiceCode { get; init; } 
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public required PartyIdentification26 Buyer { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public required PartyIdentification26 Seller { get; init; } 
    /// <summary>
    /// Financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    public required BICIdentification1 BuyerBank { get; init; } 
    /// <summary>
    /// Financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    public required BICIdentification1 SellerBank { get; init; } 
    /// <summary>
    /// Financial institution on the buyer's side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    public BICIdentification1? BuyerSideSubmittingBank { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Financial institution on the seller's side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    public BICIdentification1? SellerSideSubmittingBank { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    public PartyIdentification26? BillTo { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    public PartyIdentification26? ShipTo { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    public PartyIdentification26? Consignee { get; init; } 
    /// <summary>
    /// Goods or services that are part of a commercial trade agreement.
    /// </summary>
    public required LineItem7 Goods { get; init; } 
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    public PaymentTerms1? PaymentTerms { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies how the underlying transaction should be settled.
    /// </summary>
    public SettlementTerms2? SettlementTerms { get; init; } 
    /// <summary>
    /// Specifies the details of the payment obligation between financial institutions in this transaction.
    /// </summary>
    public PaymentObligation1? PaymentObligation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the latest date on which a data set must be matched with a baseline.
    /// </summary>
    public IsoISODate? LatestMatchDate { get; init; } 
    /// <summary>
    /// Specifies that a commercial data set is required for each shipment part of the transaction.
    /// </summary>
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that a transport data set is required for each shipment part of the transaction.
    /// </summary>
    public RequiredSubmission2? TransportDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that an insurance data set is required for each shipment part of the transaction.
    /// </summary>
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that a certificate data set is required for each shipment part of the transaction.
    /// </summary>
    public RequiredSubmission4? CertificateDataSetRequired { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies that another type of certificate data set is required for each shipment part of the transaction.
    /// </summary>
    public RequiredSubmission5? OtherCertificateDataSetRequired { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies that IntentToPayNotice message(s) are expected as part of this transaction.
    /// </summary>
    public required IsoYesNoIndicator IntentToPayExpected { get; init; } 
    
    #nullable disable
}
