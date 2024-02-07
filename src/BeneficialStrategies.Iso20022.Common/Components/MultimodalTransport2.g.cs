﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MultimodalTransport2.  ISO2002 ID# _U7MstNp-Ed-ak6NoX_4Aeg_511762628.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
public partial record MultimodalTransport2
     : IIsoXmlSerilizable<MultimodalTransport2>
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
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text? AirCarrierName { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    public IsoMax35Text? PortOfLoading { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    public IsoMax35Text? PortOfDischarge { get; init; } 
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    public IsoMax35Text? VesselName { get; init; } 
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
    /// <summary>
    /// Specifies a place in a country.
    /// </summary>
    public IsoMax35Text? TransitLocation { get; init; } 
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text? RoadCarrierName { get; init; } 
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text? RailCarrierName { get; init; } 
    
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
        if (AirCarrierName is IsoMax35Text AirCarrierNameValue)
        {
            writer.WriteStartElement(null, "AirCrrierNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AirCarrierNameValue)); // data type Max35Text System.String
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
        if (VesselName is IsoMax35Text VesselNameValue)
        {
            writer.WriteStartElement(null, "VsslNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(VesselNameValue)); // data type Max35Text System.String
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
        if (TransitLocation is IsoMax35Text TransitLocationValue)
        {
            writer.WriteStartElement(null, "TrnstLctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransitLocationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RoadCarrierName is IsoMax35Text RoadCarrierNameValue)
        {
            writer.WriteStartElement(null, "RoadCrrierNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RoadCarrierNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RailCarrierName is IsoMax35Text RailCarrierNameValue)
        {
            writer.WriteStartElement(null, "RailCrrierNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RailCarrierNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static MultimodalTransport2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
