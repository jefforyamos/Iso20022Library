﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmAndDigest1.  ISO2002 ID# _OTgzMjQw-AOSNFX-8224494.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a cryptographic digest algorithm and value.
/// </summary>
public partial record AlgorithmAndDigest1
     : IIsoXmlSerilizable<AlgorithmAndDigest1>
{
    #nullable enable
    
    /// <summary>
    /// Digest algorithm used to create the digest.
    /// </summary>
    public required Algorithm5Code DigestAlgorithm { get; init; } 
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    public required IsoMax140Text Digest { get; init; } 
    
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
        writer.WriteStartElement(null, "DgstAlgo", xmlNamespace );
        writer.WriteValue(DigestAlgorithm.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Dgst", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(Digest)); // data type Max140Text System.String
        writer.WriteEndElement();
    }
    public static AlgorithmAndDigest1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
