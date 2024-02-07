﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Parameter6.  ISO2002 ID# _jKs7kWi8EeS87LmvcA55sg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters associated to a cryptographic encryption algorithm.
/// </summary>
public partial record Parameter6
     : IIsoXmlSerilizable<Parameter6>
{
    #nullable enable
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    public IsoMax500Binary? InitialisationVector { get; init; } 
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// </summary>
    public BytePadding1Code? BytePadding { get; init; } 
    
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
        if (EncryptionFormat is EncryptionFormat1Code EncryptionFormatValue)
        {
            writer.WriteStartElement(null, "NcrptnFrmt", xmlNamespace );
            writer.WriteValue(EncryptionFormatValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InitialisationVector is IsoMax500Binary InitialisationVectorValue)
        {
            writer.WriteStartElement(null, "InitlstnVctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Binary(InitialisationVectorValue)); // data type Max500Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (BytePadding is BytePadding1Code BytePaddingValue)
        {
            writer.WriteStartElement(null, "BPddg", xmlNamespace );
            writer.WriteValue(BytePaddingValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Parameter6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
