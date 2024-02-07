﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EncryptedContent1.  ISO2002 ID# _Sw1NtwEcEeCQm6a_G2yO_w_594420368.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
public partial record EncryptedContent1
     : IIsoXmlSerilizable<EncryptedContent1>
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    public required ContentType1Code ContentType { get; init; } 
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    public required AlgorithmIdentification1 ContentEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    public required IsoMax10000Binary EncryptedData { get; init; } 
    
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
        writer.WriteStartElement(null, "CnttTp", xmlNamespace );
        writer.WriteValue(ContentType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CnttNcrptnAlgo", xmlNamespace );
        ContentEncryptionAlgorithm.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NcrptdData", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax10000Binary(EncryptedData)); // data type Max10000Binary System.Byte[]
        writer.WriteEndElement();
    }
    public static EncryptedContent1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
