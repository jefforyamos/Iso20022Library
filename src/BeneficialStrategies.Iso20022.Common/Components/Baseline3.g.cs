﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Baseline3.  ISO2002 ID# _Sq9IZdp-Ed-ak6NoX_4Aeg_-88106768.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the commercial details of the underlying transaction.
/// </summary>
[IsoId("_Sq9IZdp-Ed-ak6NoX_4Aeg_-88106768")]
[DisplayName("Baseline")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Baseline3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Baseline3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Baseline3( DocumentIdentification1 reqSubmitterBaselineIdentification,TradeFinanceService2Code reqServiceCode,DocumentIdentification7 reqPurchaseOrderReference,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank,LineItem7 reqGoods,RequiredSubmission2 reqCommercialDataSetRequired,System.String reqIntentToPayExpected )
    {
        SubmitterBaselineIdentification = reqSubmitterBaselineIdentification;
        ServiceCode = reqServiceCode;
        PurchaseOrderReference = reqPurchaseOrderReference;
        Buyer = reqBuyer;
        Seller = reqSeller;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
        Goods = reqGoods;
        CommercialDataSetRequired = reqCommercialDataSetRequired;
        IntentToPayExpected = reqIntentToPayExpected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the baseline provided by the submitter.
    /// </summary>
    [IsoId("_Sq9IZtp-Ed-ak6NoX_4Aeg_-88106412")]
    [DisplayName("Submitter Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrBaselnId")]
    #endif
    [IsoXmlTag("SubmitrBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification1 SubmitterBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the service requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_Sq9IZ9p-Ed-ak6NoX_4Aeg_-88106766")]
    [DisplayName("Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCd")]
    #endif
    [IsoXmlTag("SvcCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeFinanceService2Code ServiceCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeFinanceService2Code ServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeFinanceService2Code ServiceCode { get; init; } 
    #else
    public TradeFinanceService2Code ServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_Sq9IaNp-Ed-ak6NoX_4Aeg_-88106437")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_SrGSUNp-Ed-ak6NoX_4Aeg_-88105957")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Buyer { get; init; } 
    #else
    public PartyIdentification26 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_SrGSUdp-Ed-ak6NoX_4Aeg_-88105879")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Seller { get; init; } 
    #else
    public PartyIdentification26 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_SrGSUtp-Ed-ak6NoX_4Aeg_-88106342")]
    [DisplayName("Buyer Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBk")]
    #endif
    [IsoXmlTag("BuyrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_SrGSU9p-Ed-ak6NoX_4Aeg_-88105802")]
    [DisplayName("Seller Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBk")]
    #endif
    [IsoXmlTag("SellrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution on the buyer&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_SrGSVNp-Ed-ak6NoX_4Aeg_-909961174")]
    [DisplayName("Buyer Side Submitting Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrSdSubmitgBk")]
    #endif
    [IsoXmlTag("BuyrSdSubmitgBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? BuyerSideSubmittingBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? BuyerSideSubmittingBank { get; init; } 
    #else
    public BICIdentification1? BuyerSideSubmittingBank { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution on the seller&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_SrGSVdp-Ed-ak6NoX_4Aeg_-481446980")]
    [DisplayName("Seller Side Submitting Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrSdSubmitgBk")]
    #endif
    [IsoXmlTag("SellrSdSubmitgBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? SellerSideSubmittingBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? SellerSideSubmittingBank { get; init; } 
    #else
    public BICIdentification1? SellerSideSubmittingBank { get; set; } 
    #endif
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_SrGSVtp-Ed-ak6NoX_4Aeg_-88105914")]
    [DisplayName("Bill To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllTo")]
    #endif
    [IsoXmlTag("BllTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? BillTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? BillTo { get; init; } 
    #else
    public PartyIdentification26? BillTo { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_SrGSV9p-Ed-ak6NoX_4Aeg_-88105837")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? ShipTo { get; init; } 
    #else
    public PartyIdentification26? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_SrGSWNp-Ed-ak6NoX_4Aeg_-88106009")]
    [DisplayName("Consignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgn")]
    #endif
    [IsoXmlTag("Consgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Consignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Consignee { get; init; } 
    #else
    public PartyIdentification26? Consignee { get; set; } 
    #endif
    
    /// <summary>
    /// Goods or services that are part of a commercial trade agreement.
    /// </summary>
    [IsoId("_SrGSWdp-Ed-ak6NoX_4Aeg_-88106721")]
    [DisplayName("Goods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Goods")]
    #endif
    [IsoXmlTag("Goods")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LineItem7 Goods { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LineItem7 Goods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItem7 Goods { get; init; } 
    #else
    public LineItem7 Goods { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_SrQDUNp-Ed-ak6NoX_4Aeg_-88106377")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    public PaymentTerms1? PaymentTerms { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _SrQDUNp-Ed-ak6NoX_4Aeg_-88106377
    
    /// <summary>
    /// Specifies how the underlying transaction should be settled.
    /// </summary>
    [IsoId("_SrQDUdp-Ed-ak6NoX_4Aeg_-88106689")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTerms2? SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms2? SettlementTerms { get; init; } 
    #else
    public SettlementTerms2? SettlementTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the payment obligation between financial institutions in this transaction.
    /// </summary>
    [IsoId("_SrQDUtp-Ed-ak6NoX_4Aeg_491944940")]
    [DisplayName("Payment Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtOblgtn")]
    #endif
    [IsoXmlTag("PmtOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentObligation1? PaymentObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentObligation1? PaymentObligation { get; init; } 
    #else
    public PaymentObligation1? PaymentObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the latest date on which a data set must be matched with a baseline.
    /// </summary>
    [IsoId("_SrQDU9p-Ed-ak6NoX_4Aeg_879823932")]
    [DisplayName("Latest Match Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstMtchDt")]
    #endif
    [IsoXmlTag("LatstMtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LatestMatchDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LatestMatchDate { get; init; } 
    #else
    public System.DateOnly? LatestMatchDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a commercial data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVNp-Ed-ak6NoX_4Aeg_1421007322")]
    [DisplayName("Commercial Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclDataSetReqrd")]
    #endif
    [IsoXmlTag("ComrclDataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    #else
    public RequiredSubmission2 CommercialDataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a transport data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVdp-Ed-ak6NoX_4Aeg_1841207283")]
    [DisplayName("Transport Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtDataSetReqrd")]
    #endif
    [IsoXmlTag("TrnsprtDataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequiredSubmission2? TransportDataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequiredSubmission2? TransportDataSetRequired { get; init; } 
    #else
    public RequiredSubmission2? TransportDataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that an insurance data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVtp-Ed-ak6NoX_4Aeg_1927097202")]
    [DisplayName("Insurance Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncDataSetReqrd")]
    #endif
    [IsoXmlTag("InsrncDataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; } 
    #else
    public RequiredSubmission3? InsuranceDataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDV9p-Ed-ak6NoX_4Aeg_-1995693519")]
    [DisplayName("Certificate Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertDataSetReqrd")]
    #endif
    [IsoXmlTag("CertDataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequiredSubmission4? CertificateDataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequiredSubmission4? CertificateDataSetRequired { get; init; } 
    #else
    public RequiredSubmission4? CertificateDataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that another type of certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrZNQNp-Ed-ak6NoX_4Aeg_-2130617300")]
    [DisplayName("Other Certificate Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCertDataSetReqrd")]
    #endif
    [IsoXmlTag("OthrCertDataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequiredSubmission5? OtherCertificateDataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequiredSubmission5? OtherCertificateDataSetRequired { get; init; } 
    #else
    public RequiredSubmission5? OtherCertificateDataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that IntentToPayNotice message(s) are expected as part of this transaction.
    /// </summary>
    [IsoId("_SrZNQdp-Ed-ak6NoX_4Aeg_2027510023")]
    [DisplayName("Intent To Pay Expected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InttToPayXpctd")]
    #endif
    [IsoXmlTag("InttToPayXpctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator IntentToPayExpected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IntentToPayExpected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IntentToPayExpected { get; init; } 
    #else
    public System.String IntentToPayExpected { get; set; } 
    #endif
    
    
    #nullable disable
    
}
