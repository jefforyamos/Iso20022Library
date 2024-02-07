﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportBySea6.  ISO2002 ID# _WhO5YRriEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
public partial record TransportBySea6
     : IIsoXmlSerilizable<TransportBySea6>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    public IsoMax35Text? PortOfLoading { get; init; } 
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    public IsoMax35Text? PortOfDischarge { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _W4LZwxriEeOVR9VN6fAMUg
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    public IsoMax70Text? VesselName { get; init; } 
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax70Text? SeaCarrierName { get; init; } 
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    public CountryCode? SeaCarrierCountry { get; init; } 
    /// <summary>
    /// Name of the carrier's (for example, shipping company's) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    public IsoMax70Text? CarrierAgentName { get; init; } 
    /// <summary>
    /// Country of registration of the carrier's (for example, shipping company's) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    public CountryCode? CarrierAgentCountry { get; init; } 
    
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
        if (PortOfLoading is IsoMax35Text PortOfLoadingValue)
        {
            writer.WriteStartElement(null, "PortOfLoadng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PortOfLoadingValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        // Not sure how to serialize PortOfDischarge, multiplicity Unknown
        if (VesselName is IsoMax70Text VesselNameValue)
        {
            writer.WriteStartElement(null, "VsslNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(VesselNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (SeaCarrierName is IsoMax70Text SeaCarrierNameValue)
        {
            writer.WriteStartElement(null, "SeaCrrierNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(SeaCarrierNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (SeaCarrierCountry is CountryCode SeaCarrierCountryValue)
        {
            writer.WriteStartElement(null, "SeaCrrierCtry", xmlNamespace );
            writer.WriteValue(SeaCarrierCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CarrierAgentName is IsoMax70Text CarrierAgentNameValue)
        {
            writer.WriteStartElement(null, "CrrierAgtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(CarrierAgentNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (CarrierAgentCountry is CountryCode CarrierAgentCountryValue)
        {
            writer.WriteStartElement(null, "CrrierAgtCtry", xmlNamespace );
            writer.WriteValue(CarrierAgentCountryValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static TransportBySea6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
