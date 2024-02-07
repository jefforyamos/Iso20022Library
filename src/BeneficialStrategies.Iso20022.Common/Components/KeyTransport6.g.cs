﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for KeyTransport6.  ISO2002 ID# _KqPFMaRZEeeWXKXf3KjtmQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
public partial record KeyTransport6
     : IIsoXmlSerilizable<KeyTransport6>
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
    public required AlgorithmIdentification27 KeyEncryptionAlgorithm { get; init; } 
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
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
    public static KeyTransport6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
