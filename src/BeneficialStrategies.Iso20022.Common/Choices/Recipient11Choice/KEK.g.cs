﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KEK.  ISO2002 ID# _6trNg1E0EeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Recipient11Choice;

/// <summary>
/// Key encryption key using previously distributed symmetric key.
/// </summary>
public partial record KEK : Recipient11Choice_
     , IIsoXmlSerilizable<KEK>
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the key encryption key (KEK).
    /// </summary>
    public required KEKIdentifier7 KEKIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public IsoMax500Binary? EncryptedKey { get; init; } 
    
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
        writer.WriteStartElement(null, "KEKId", xmlNamespace );
        KEKIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "KeyNcrptnAlgo", xmlNamespace );
        KeyEncryptionAlgorithm.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EncryptedKey is IsoMax500Binary EncryptedKeyValue)
        {
            writer.WriteStartElement(null, "NcrptdKey", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Binary(EncryptedKeyValue)); // data type Max500Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static new KEK Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
