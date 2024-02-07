﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Traceability4.  ISO2002 ID# _iwOuUYnzEeS9F4Qrq_eaVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of partners involved in exchange from the ATM to the issuer, with the relative timestamp of their exchanges.
/// </summary>
public partial record Traceability4
     : IIsoXmlSerilizable<Traceability4>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    public required GenericIdentification77 RelayIdentification { get; init; } 
    /// <summary>
    /// Identification of the relay node in the path, to enable identification of several hosts in parallel.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
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
        if (SequenceNumber is IsoMax35Text SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SequenceNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TracDtTmIn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TraceDateTimeIn)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TracDtTmOut", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TraceDateTimeOut)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static Traceability4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
