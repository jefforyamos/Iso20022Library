﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItem13.  ISO2002 ID# _KK1ZcQgHEeSeS5xdjFfOTw.
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
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
[IsoId("_KK1ZcQgHEeSeS5xdjFfOTw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Line Item")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItem13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LineItem13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LineItem13( System.String reqPartialShipment,System.Decimal reqLineItemsTotalAmount,System.Decimal reqTotalNetAmount )
    {
        PartialShipment = reqPartialShipment;
        LineItemsTotalAmount = reqLineItemsTotalAmount;
        TotalNetAmount = reqTotalNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_KiCYWQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Goods And Or Services Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? GoodsAndOrServicesDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GoodsAndOrServicesDescription { get; init; } 
    #else
    public System.String? GoodsAndOrServicesDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    [IsoId("_KiCYWwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Partial Shipment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartialShipment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PartialShipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartialShipment { get; init; } 
    #else
    public System.String PartialShipment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    [IsoId("_KiCYXQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trans Shipment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransShipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransShipment { get; init; } 
    #else
    public System.String? TransShipment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    [IsoId("_KiCYXwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Shipment Date Range")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    #else
    public ShipmentDateRange1? ShipmentDateRange { get; set; } 
    #endif
    
    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    [IsoId("_KiCYYQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Line Item Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public LineItemDetails13? LineItemDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _KiCYYQgHEeSeS5xdjFfOTw
    
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    [IsoId("_KiCYYwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Line Items Total Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCurrencyAndAmount LineItemsTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal LineItemsTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal LineItemsTotalAmount { get; init; } 
    #else
    public System.Decimal LineItemsTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_KiCYZQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Routing Summary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportMeans5? RoutingSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans5? RoutingSummary { get; init; } 
    #else
    public TransportMeans5? RoutingSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    [IsoId("_KiCYZwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Incoterms")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms4? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms4? Incoterms { get; init; } 
    #else
    public Incoterms4? Incoterms { get; set; } 
    #endif
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_KiCYaQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Adjustment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment7? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment7? Adjustment { get; init; } 
    #else
    public Adjustment7? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_KiCYawgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Freight Charges")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge24? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge24? FreightCharges { get; init; } 
    #else
    public Charge24? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    [IsoId("_KiCYbQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax23? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax23? Tax { get; init; } 
    #else
    public Tax23? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    [IsoId("_KiCYbwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Net Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal TotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TotalNetAmount { get; init; } 
    #else
    public System.Decimal TotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_KiCYcQgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Buyer Defined Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? BuyerDefinedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    [IsoId("_KiCYcwgHEeSeS5xdjFfOTw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller Defined Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    #else
    public UserDefinedInformation1? SellerDefinedInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
