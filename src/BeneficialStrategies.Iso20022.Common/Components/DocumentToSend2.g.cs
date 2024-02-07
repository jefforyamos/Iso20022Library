﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentToSend2.  ISO2002 ID# _L2J9sQgqEeSUG-8hqXsVMQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Determine the type of document and the type of communication method to be used to notify a Party.
/// </summary>
public partial record DocumentToSend2
     : IIsoXmlSerilizable<DocumentToSend2>
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    public required IsoMax140Text Type { get; init; } 
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    public required PartyIdentification2Choice_ Recipient { get; init; } 
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    public required CommunicationMethod3Choice_ MethodOfTransmission { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(Type)); // data type Max140Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Rcpt", xmlNamespace );
        Recipient.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MtdOfTrnsmssn", xmlNamespace );
        MethodOfTransmission.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DocumentToSend2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
