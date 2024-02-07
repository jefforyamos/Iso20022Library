﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyTransport.  ISO2002 ID# _EE9KgQxqEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Recipient8Choice;

/// <summary>
/// Encryption key using previously distributed asymmetric public key.
/// </summary>
public partial record KeyTransport : Recipient8Choice_
     , IIsoXmlSerilizable<KeyTransport>
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    public required Recipient5Choice_ RecipientIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public required IsoMax5000Binary EncryptedKey { get; init; } 
    
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
        if (Version is IsoNumber VersionValue)
        {
            writer.WriteStartElement(null, "Vrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(VersionValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RcptId", xmlNamespace );
        RecipientIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "KeyNcrptnAlgo", xmlNamespace );
        KeyEncryptionAlgorithm.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NcrptdKey", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax5000Binary(EncryptedKey)); // data type Max5000Binary System.Byte[]
        writer.WriteEndElement();
    }
    public static new KeyTransport Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
