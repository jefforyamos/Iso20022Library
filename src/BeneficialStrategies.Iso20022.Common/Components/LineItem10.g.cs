﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItem10.  ISO2002 ID# _SuJtLAEcEeCQm6a_G2yO_w_-1957014618.
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
/// Unit of information showing the related provision of products and/or services and monetary summations reported as a discrete line items.
/// </summary>
[IsoId("_SuJtLAEcEeCQm6a_G2yO_w_-1957014618")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Line Item")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The unique identification of this invoice line item.
    /// </summary>
    [IsoId("_SuJtLQEcEeCQm6a_G2yO_w_276499295")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Something that is produced and sold as the result of an industrial process.
    /// </summary>
    [IsoId("_SuTeIAEcEeCQm6a_G2yO_w_-1081676107")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeProduct1? TradeProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeProduct1? TradeProduct { get; init; } 
    #else
    public TradeProduct1? TradeProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Purchase order reference assigned by the buyer related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIQEcEeCQm6a_G2yO_w_1418969012")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer Order Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification23? BuyerOrderIdentification { get; init; } 
    #else
    public DocumentIdentification23? BuyerOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contract reference related to the provision of products and/or services for this line item.
    /// </summary>
    [IsoId("_SuTeIgEcEeCQm6a_G2yO_w_-2047566678")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contract Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? ContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? ContractIdentification { get; init; } 
    #else
    public DocumentIdentification22? ContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specific purchase account for recording debits and credits for accounting purposes.
    /// </summary>
    [IsoId("_SuTeIwEcEeCQm6a_G2yO_w_-1211043201")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Purchase Accounting Account")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountingAccount1? PurchaseAccountingAccount { get; init; } 
    #else
    public AccountingAccount1? PurchaseAccountingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_SuTeJAEcEeCQm6a_G2yO_w_-769209174")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCurrencyAndAmount? NetPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? NetPrice { get; init; } 
    #else
    public System.Decimal? NetPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity and conversion factor on which the net price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeJQEcEeCQm6a_G2yO_w_-899649920")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Price Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity4? NetPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4? NetPriceQuantity { get; init; } 
    #else
    public Quantity4? NetPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge applied to the net price.
    /// </summary>
    [IsoId("_SuTeJgEcEeCQm6a_G2yO_w_328165622")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Price Allowance Charge")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge1? NetPriceAllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Net weight of the product.
    /// </summary>
    [IsoId("_SuTeJwEcEeCQm6a_G2yO_w_917729180")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Weight")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? NetWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? NetWeight { get; init; } 
    #else
    public Quantity3? NetWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Gross price of the product and/or service.
    /// </summary>
    [IsoId("_SuTeKAEcEeCQm6a_G2yO_w_415525348")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCurrencyAndAmount? GrossPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? GrossPrice { get; init; } 
    #else
    public System.Decimal? GrossPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity and conversion factor on which the gross price is based for this line item product and/or service.
    /// </summary>
    [IsoId("_SuTeKQEcEeCQm6a_G2yO_w_-26631818")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Price Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity4? GrossPriceQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity4? GrossPriceQuantity { get; init; } 
    #else
    public Quantity4? GrossPriceQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Gross weight of the product.
    /// </summary>
    [IsoId("_SuTeKgEcEeCQm6a_G2yO_w_-502407978")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Weight")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? GrossWeight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? GrossWeight { get; init; } 
    #else
    public Quantity3? GrossWeight { get; set; } 
    #endif
    
    /// <summary>
    /// Logistics service charge for this line item.
    /// </summary>
    [IsoId("_SuTeKwEcEeCQm6a_G2yO_w_-1074285510")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Logistics Charge")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargesDetails2? LogisticsCharge { get; init; } 
    #else
    public ChargesDetails2? LogisticsCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
    /// </summary>
    [IsoId("_SuTeLAEcEeCQm6a_G2yO_w_-1718452272")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemTax1? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemTax1? Tax { get; init; } 
    #else
    public LineItemTax1? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Allowance or charge specified for this line item.
    /// </summary>
    [IsoId("_SuTeLQEcEeCQm6a_G2yO_w_-1288890455")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Allowance Charge")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAllowanceCharge1? AllowanceCharge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAllowanceCharge1? AllowanceCharge { get; init; } 
    #else
    public LineItemAllowanceCharge1? AllowanceCharge { get; set; } 
    #endif
    
    /// <summary>
    /// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
    /// </summary>
    [IsoId("_SuTeLgEcEeCQm6a_G2yO_w_1555627299")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Adjustment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment4? FinancialAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment4? FinancialAdjustment { get; init; } 
    #else
    public Adjustment4? FinancialAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity billed for this line item.
    /// </summary>
    [IsoId("_SuTeLwEcEeCQm6a_G2yO_w_-72954526")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Billed Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? BilledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? BilledQuantity { get; init; } 
    #else
    public Quantity3? BilledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of product packages delivered.
    /// </summary>
    [IsoId("_SuTeMAEcEeCQm6a_G2yO_w_1141764402")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Package Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? PackageQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PackageQuantity { get; init; } 
    #else
    public System.UInt64? PackageQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units per package in this line item for a supply chain trade delivery.
    /// </summary>
    [IsoId("_SuTeMQEcEeCQm6a_G2yO_w_1057688708")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Per Package Unit Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? PerPackageUnitQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? PerPackageUnitQuantity { get; init; } 
    #else
    public Quantity3? PerPackageUnitQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Physical packaging of the product.
    /// </summary>
    [IsoId("_SucoEAEcEeCQm6a_G2yO_w_-531731082")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Packaging")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Packaging1? Packaging { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Packaging1? Packaging { get; init; } 
    #else
    public Packaging1? Packaging { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity that is free of charge for this line item.
    /// </summary>
    [IsoId("_SucoEQEcEeCQm6a_G2yO_w_695882671")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charge Free Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? ChargeFreeQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? ChargeFreeQuantity { get; init; } 
    #else
    public Quantity3? ChargeFreeQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement started for a line item. For instance the start amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEgEcEeCQm6a_G2yO_w_1824445894")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Measure Quantity Start")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? MeasureQuantityStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? MeasureQuantityStart { get; init; } 
    #else
    public Quantity3? MeasureQuantityStart { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity value on which the quantity measurement ended for a line item. For instance the end amount of a meter reading for an electricity supplier.
    /// </summary>
    [IsoId("_SucoEwEcEeCQm6a_G2yO_w_-1570728431")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Measure Quantity End")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? MeasureQuantityEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? MeasureQuantityEnd { get; init; } 
    #else
    public Quantity3? MeasureQuantityEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the clock time measure started for a line item.
    /// </summary>
    [IsoId("_SucoFAEcEeCQm6a_G2yO_w_-1177982434")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Measure Date Time Start")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MeasureDateTimeStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MeasureDateTimeStart { get; init; } 
    #else
    public System.DateTime? MeasureDateTimeStart { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the clock time measure ended for a line item.
    /// </summary>
    [IsoId("_SucoFQEcEeCQm6a_G2yO_w_-1092370631")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Measure Date Time End")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MeasureDateTimeEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MeasureDateTimeEnd { get; init; } 
    #else
    public System.DateTime? MeasureDateTimeEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_SucoFgEcEeCQm6a_G2yO_w_392335545")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ship To")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? ShipTo { get; init; } 
    #else
    public TradeParty1? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_SucoFwEcEeCQm6a_G2yO_w_-1792779697")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Incoterms")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms3? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms3? Incoterms { get; init; } 
    #else
    public Incoterms3? Incoterms { get; set; } 
    #endif
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGAEcEeCQm6a_G2yO_w_-1420879465")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivery Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DeliveryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DeliveryDateTime { get; init; } 
    #else
    public System.DateTime? DeliveryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services for this line item.
    /// </summary>
    [IsoId("_SucoGQEcEeCQm6a_G2yO_w_1419263589")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivery Note Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? DeliveryNoteIdentification { get; init; } 
    #else
    public DocumentIdentification22? DeliveryNoteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Monetary totals for this line item.
    /// </summary>
    [IsoId("_SucoGgEcEeCQm6a_G2yO_w_525193840")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Monetary Summation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemMonetarySummation1? MonetarySummation { get; init; } 
    #else
    public LineItemMonetarySummation1? MonetarySummation { get; set; } 
    #endif
    
    /// <summary>
    /// Note included in this line item.
    /// </summary>
    [IsoId("_SucoGwEcEeCQm6a_G2yO_w_402346471")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Included Note")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation1? IncludedNote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation1? IncludedNote { get; init; } 
    #else
    public AdditionalInformation1? IncludedNote { get; set; } 
    #endif
    
    
    #nullable disable
    
}
