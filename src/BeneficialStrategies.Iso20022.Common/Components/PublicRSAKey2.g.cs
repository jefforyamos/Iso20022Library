﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PublicRSAKey2.  ISO2002 ID# _uH2O4Y4SEeW6h7rGyYlyTg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value of the public component of a RSA key.
/// </summary>
public partial record PublicRSAKey2
     : IIsoXmlSerilizable<PublicRSAKey2>
{
    #nullable enable
    
    /// <summary>
    /// Asymmetric cryptographic algorithm.
    /// </summary>
    public Algorithm7Code? Algorithm { get; init; } 
    /// <summary>
    /// Public key value.
    /// </summary>
    public required PublicRSAKey1 PublicKeyValue { get; init; } 
    
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
        if (Algorithm is Algorithm7Code AlgorithmValue)
        {
            writer.WriteStartElement(null, "Algo", xmlNamespace );
            writer.WriteValue(AlgorithmValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PblcKeyVal", xmlNamespace );
        PublicKeyValue.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static PublicRSAKey2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
