﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification25.  ISO2002 ID# _YSxbcaQtEeeWXKXf3KjtmQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for encryptions with a symmetric cryptographic key.
/// </summary>
public partial record AlgorithmIdentification25
     : IIsoXmlSerilizable<AlgorithmIdentification25>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the encryption algorithm.
    /// </summary>
    public required Algorithm23Code Algorithm { get; init; } 
    /// <summary>
    /// Parameters associated with the CBC (Chain Block Chaining) encryption algorithm.
    /// </summary>
    public Parameter7? Parameter { get; init; } 
    
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
        writer.WriteStartElement(null, "Algo", xmlNamespace );
        writer.WriteValue(Algorithm.ToString()); // Enum value
        writer.WriteEndElement();
        if (Parameter is Parameter7 ParameterValue)
        {
            writer.WriteStartElement(null, "Param", xmlNamespace );
            ParameterValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AlgorithmIdentification25 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
