﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MultimodalTransport.  ISO2002 ID# _U7oxltp-Ed-ak6NoX_4Aeg_1541248006.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransportMeans1Choice;

/// <summary>
/// Specifies the different movements and places and their role in a multimodal conveyance of goods.
/// </summary>
public partial record MultimodalTransport : TransportMeans1Choice_
     , IIsoXmlSerilizable<MultimodalTransport>
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    public AirportName1Choice_? DepartureAirport { get; init; } 
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    public AirportName1Choice_? DestinationAirport { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    public IsoMax35Text? PortOfLoading { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    public IsoMax35Text? PortOfDischarge { get; init; } 
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    public IsoMax35Text? PlaceOfReceipt { get; init; } 
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    public IsoMax35Text? PlaceOfDelivery { get; init; } 
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    public IsoMax35Text? TakingInCharge { get; init; } 
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    public IsoMax35Text? PlaceOfFinalDestination { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (DepartureAirport is AirportName1Choice_ DepartureAirportValue)
        {
            writer.WriteStartElement(null, "DprtureAirprt", xmlNamespace );
            DepartureAirportValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DestinationAirport is AirportName1Choice_ DestinationAirportValue)
        {
            writer.WriteStartElement(null, "DstnAirprt", xmlNamespace );
            DestinationAirportValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PortOfLoading is IsoMax35Text PortOfLoadingValue)
        {
            writer.WriteStartElement(null, "PortOfLoadng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PortOfLoadingValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PortOfDischarge is IsoMax35Text PortOfDischargeValue)
        {
            writer.WriteStartElement(null, "PortOfDschrge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PortOfDischargeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PlaceOfReceipt is IsoMax35Text PlaceOfReceiptValue)
        {
            writer.WriteStartElement(null, "PlcOfRct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PlaceOfReceiptValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PlaceOfDelivery is IsoMax35Text PlaceOfDeliveryValue)
        {
            writer.WriteStartElement(null, "PlcOfDlvry", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PlaceOfDeliveryValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TakingInCharge is IsoMax35Text TakingInChargeValue)
        {
            writer.WriteStartElement(null, "TakngInChrg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TakingInChargeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PlaceOfFinalDestination is IsoMax35Text PlaceOfFinalDestinationValue)
        {
            writer.WriteStartElement(null, "PlcOfFnlDstn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PlaceOfFinalDestinationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new MultimodalTransport Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
