﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Baseline4.  ISO2002 ID# _Ym19EdM7EeK-v49t1oWkNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the commercial details of the underlying transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record Baseline4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the baseline provided by the submitter.
    /// </summary>
    [DataMember]
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    /// <summary>
    /// Identifies the service requested by the submitter by means of a code.
    /// </summary>
    [DataMember]
    public required TradeFinanceService2Code ServiceCode { get; init; } 
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [DataMember]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [DataMember]
    public required PartyIdentification26 Buyer { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [DataMember]
    public required PartyIdentification26 Seller { get; init; } 
    /// <summary>
    /// Financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [DataMember]
    public required BICIdentification1 BuyerBank { get; init; } 
    /// <summary>
    /// Financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [DataMember]
    public required BICIdentification1 SellerBank { get; init; } 
    /// <summary>
    /// Financial institution on the buyer's side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [DataMember]
    public ValueList<BICIdentification1> BuyerSideSubmittingBank { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Financial institution on the seller's side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [DataMember]
    public ValueList<BICIdentification1> SellerSideSubmittingBank { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [DataMember]
    public PartyIdentification26? BillTo { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [DataMember]
    public PartyIdentification26? ShipTo { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [DataMember]
    public PartyIdentification26? Consignee { get; init; } 
    /// <summary>
    /// Goods or services that are part of a commercial trade agreement.
    /// </summary>
    [DataMember]
    public required LineItem11 Goods { get; init; } 
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [DataMember]
    public ValueList<PaymentTerms5> PaymentTerms { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies how the underlying transaction should be settled.
    /// </summary>
    [DataMember]
    public SettlementTerms3? SettlementTerms { get; init; } 
    /// <summary>
    /// Specifies the details of the payment obligation between financial institutions in this transaction.
    /// </summary>
    [DataMember]
    public ValueList<PaymentObligation2> PaymentObligation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the latest date on which a data set must be matched with a baseline.
    /// </summary>
    [DataMember]
    public IsoISODate? LatestMatchDate { get; init; } 
    /// <summary>
    /// Specifies that a commercial data set is required for each shipment part of the transaction.
    /// </summary>
    [DataMember]
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that a transport data set is required for each shipment part of the transaction.
    /// </summary>
    [DataMember]
    public RequiredSubmission2? TransportDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that an insurance data set is required for each shipment part of the transaction.
    /// </summary>
    [DataMember]
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; } 
    /// <summary>
    /// Specifies that a certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [DataMember]
    public ValueList<RequiredSubmission4> CertificateDataSetRequired { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies that another type of certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [DataMember]
    public ValueList<RequiredSubmission5> OtherCertificateDataSetRequired { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies that IntentToPayNotice message(s) are expected as part of this transaction.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator IntentToPayExpected { get; init; } 
    
    #nullable disable
}
