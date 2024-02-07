﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DigestedData2.  ISO2002 ID# _QrKd8QiuEeKn9O5oyej_zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digest computed on the identified data.
/// </summary>
public partial record DigestedData2
     : IIsoXmlSerilizable<DigestedData2>
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm.
    /// </summary>
    public AlgorithmIdentification5? DigestAlgorithm { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Q3NV5QiuEeKn9O5oyej_zw
    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
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
        if (Version is IsoNumber VersionValue)
        {
            writer.WriteStartElement(null, "Vrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(VersionValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        // Not sure how to serialize DigestAlgorithm, multiplicity Unknown
        writer.WriteStartElement(null, "NcpsltdCntt", xmlNamespace );
        EncapsulatedContent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Dgst", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(Digest)); // data type Max140Text System.String
        writer.WriteEndElement();
    }
    public static DigestedData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
