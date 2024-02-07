﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteraction9.  ISO2002 ID# _-ioIkdkGEeiojJsa6FYyew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction (POI) performing the transaction.
/// </summary>
public partial record PointOfInteraction9
     : IIsoXmlSerilizable<PointOfInteraction9>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    public required GenericIdentification171 Identification { get; init; } 
    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    public IsoMax70Text? SystemName { get; init; } 
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? GroupIdentification { get; init; } 
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public PointOfInteractionCapabilities8? Capabilities { get; init; } 
    /// <summary>
    /// Time zone name as defined by IANA (Internet Assigned Numbers Authority) in the time zone data base. America/Chicago or Europe/Paris are examples of time zone names.
    /// </summary>
    public IsoMax70Text? TimeZone { get; init; } 
    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// </summary>
    public LocationCategory3Code? TerminalIntegration { get; init; } 
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public PointOfInteractionComponent9? Component { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SystemName is IsoMax70Text SystemNameValue)
        {
            writer.WriteStartElement(null, "SysNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(SystemNameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (GroupIdentification is IsoMax35Text GroupIdentificationValue)
        {
            writer.WriteStartElement(null, "GrpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(GroupIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Capabilities is PointOfInteractionCapabilities8 CapabilitiesValue)
        {
            writer.WriteStartElement(null, "Cpblties", xmlNamespace );
            CapabilitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TimeZone is IsoMax70Text TimeZoneValue)
        {
            writer.WriteStartElement(null, "TmZone", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(TimeZoneValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (TerminalIntegration is LocationCategory3Code TerminalIntegrationValue)
        {
            writer.WriteStartElement(null, "TermnlIntgtn", xmlNamespace );
            writer.WriteValue(TerminalIntegrationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Component is PointOfInteractionComponent9 ComponentValue)
        {
            writer.WriteStartElement(null, "Cmpnt", xmlNamespace );
            ComponentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PointOfInteraction9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
