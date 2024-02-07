﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Traceability8.  ISO2002 ID# _crjSgQx6Eeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
/// </summary>
public partial record Traceability8
     : IIsoXmlSerilizable<Traceability8>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    public required GenericIdentification177 RelayIdentification { get; init; } 
    /// <summary>
    /// Name of the outgoing protocol used by the node.
    /// </summary>
    public IsoMax35Text? ProtocolName { get; init; } 
    /// <summary>
    /// Version of the protocol.
    /// </summary>
    public IsoMax6Text? ProtocolVersion { get; init; } 
    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    public required IsoISODateTime TraceDateTimeIn { get; init; } 
    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    public required IsoISODateTime TraceDateTimeOut { get; init; } 
    
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
        writer.WriteStartElement(null, "RlayId", xmlNamespace );
        RelayIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProtocolName is IsoMax35Text ProtocolNameValue)
        {
            writer.WriteStartElement(null, "PrtcolNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProtocolNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProtocolVersion is IsoMax6Text ProtocolVersionValue)
        {
            writer.WriteStartElement(null, "PrtcolVrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax6Text(ProtocolVersionValue)); // data type Max6Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TracDtTmIn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TraceDateTimeIn)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TracDtTmOut", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TraceDateTimeOut)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static Traceability8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
