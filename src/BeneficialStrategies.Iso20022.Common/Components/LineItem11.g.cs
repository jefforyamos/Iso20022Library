﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItem11.  ISO2002 ID# _nxeDkefIEeKNfc-Rw_dPYg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial details of a trade transaction between a buyer and a seller.
/// </summary>
public partial record LineItem11
     : IIsoXmlSerilizable<LineItem11>
{
    #nullable enable
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    public IsoMax70Text? GoodsDescription { get; init; } 
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
    public LineItemDetails10? LineItemDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _oNFooefIEeKNfc-Rw_dPYg
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
    public Adjustment7? Adjustment { get; init; } 
    /// <summary>
    /// Maximum charges related to the conveyance of goods.
    /// </summary>
    public Charge24? FreightCharges { get; init; } 
    /// <summary>
    /// Amount of money due to the government or tax authority, according to various pre-defined parameters linked to the value of the goods in a trade transaction.
    /// </summary>
    public Tax23? Tax { get; init; } 
    /// <summary>
    /// Total net amount of a trade transaction. Total amount resulting from the gross amount plus freight charges, tax and plus/minus Adjustments.
    /// </summary>
    public required IsoCurrencyAndAmount TotalNetAmount { get; init; } 
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (GoodsDescription is IsoMax70Text GoodsDescriptionValue)
        {
            writer.WriteStartElement(null, "GoodsDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(GoodsDescriptionValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrtlShipmnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PartialShipment)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (TransShipment is IsoYesNoIndicator TransShipmentValue)
        {
            writer.WriteStartElement(null, "TrnsShipmnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(TransShipmentValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ShipmentDateRange is ShipmentDateRange1 ShipmentDateRangeValue)
        {
            writer.WriteStartElement(null, "ShipmntDtRg", xmlNamespace );
            ShipmentDateRangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize LineItemDetails, multiplicity Unknown
        writer.WriteStartElement(null, "LineItmsTtlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(LineItemsTotalAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (RoutingSummary is TransportMeans5 RoutingSummaryValue)
        {
            writer.WriteStartElement(null, "RtgSummry", xmlNamespace );
            RoutingSummaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Incoterms is Incoterms4 IncotermsValue)
        {
            writer.WriteStartElement(null, "Incotrms", xmlNamespace );
            IncotermsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Adjustment is Adjustment7 AdjustmentValue)
        {
            writer.WriteStartElement(null, "Adjstmnt", xmlNamespace );
            AdjustmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FreightCharges is Charge24 FreightChargesValue)
        {
            writer.WriteStartElement(null, "FrghtChrgs", xmlNamespace );
            FreightChargesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tax is Tax23 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlNetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(TotalNetAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (BuyerDefinedInformation is UserDefinedInformation1 BuyerDefinedInformationValue)
        {
            writer.WriteStartElement(null, "BuyrDfndInf", xmlNamespace );
            BuyerDefinedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SellerDefinedInformation is UserDefinedInformation1 SellerDefinedInformationValue)
        {
            writer.WriteStartElement(null, "SellrDfndInf", xmlNamespace );
            SellerDefinedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static LineItem11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
