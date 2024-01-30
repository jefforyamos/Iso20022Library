﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItem13.  ISO2002 ID# _KK1ZcQgHEeSeS5xdjFfOTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
public partial record LineItem13
{
    #nullable enable
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    public IsoMax70Text? GoodsAndOrServicesDescription { get; init; } 
    /// <summary>
    /// Indicates whether or not partial shipments are allowed.
    /// </summary>
    public required IsoYesNoIndicator PartialShipment { get; init; } 
    /// <summary>
    /// Indicates whether or not transshipment of goods is allowed.
    /// </summary>
    public IsoYesNoIndicator? TransShipment { get; init; } 
    /// <summary>
    /// Specifies an earliest shipment date and a latest shipment date.
    /// </summary>
    public ShipmentDateRange1? ShipmentDateRange { get; init; } 
    /// <summary>
    /// Goods or services that are purchased.
    /// </summary>
    public LineItemDetails13? LineItemDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the total amount of all line items (incl. their adjustments).
    /// </summary>
    public required IsoCurrencyAndAmount LineItemsTotalAmount { get; init; } 
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    public TransportMeans5? RoutingSummary { get; init; } 
    /// <summary>
    /// Specifies the applicable Incoterms and associated location. Latest version of Incoterms in effect at the date of message creation.
    /// </summary>
    public Incoterms4? Incoterms { get; init; } 
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    public Adjustment7? Adjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    public Charge24? FreightCharges { get; init; } 
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    public Tax23? Tax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    public required IsoCurrencyAndAmount TotalNetAmount { get; init; } 
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? BuyerDefinedInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? SellerDefinedInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
