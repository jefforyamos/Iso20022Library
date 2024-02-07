﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportDataSet5.  ISO2002 ID# _2DIaMTckEeSaC-PiOaz_KQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the transportation of goods that are part of a commercial trade agreement.
/// </summary>
public partial record TransportDataSet5
     : IIsoXmlSerilizable<TransportDataSet5>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted transport data set.
    /// </summary>
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public PartyIdentification26? Buyer { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public PartyIdentification26? Seller { get; init; } 
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    public required PartyIdentification26 Consignor { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    public PartyIdentification26? Consignee { get; init; } 
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    public PartyIdentification26? ShipTo { get; init; } 
    /// <summary>
    /// Specifies the shipment date, the charges, the routing and the goods that are described in the transport document.
    /// </summary>
    public required TransportDetails4 TransportInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "DataSetId", xmlNamespace );
        DataSetIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Buyer is PartyIdentification26 BuyerValue)
        {
            writer.WriteStartElement(null, "Buyr", xmlNamespace );
            BuyerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Seller is PartyIdentification26 SellerValue)
        {
            writer.WriteStartElement(null, "Sellr", xmlNamespace );
            SellerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Consgnr", xmlNamespace );
        Consignor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Consignee is PartyIdentification26 ConsigneeValue)
        {
            writer.WriteStartElement(null, "Consgn", xmlNamespace );
            ConsigneeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ShipTo is PartyIdentification26 ShipToValue)
        {
            writer.WriteStartElement(null, "ShipTo", xmlNamespace );
            ShipToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrnsprtInf", xmlNamespace );
        TransportInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TransportDataSet5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
