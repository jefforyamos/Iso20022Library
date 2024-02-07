﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification10.  ISO2002 ID# _ckn7wTF2EeO118ZQJgaQSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm and parameters for the MAC computation.
/// </summary>
public partial record AlgorithmIdentification10
     : IIsoXmlSerilizable<AlgorithmIdentification10>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    public required Algorithm10Code Algorithm { get; init; } 
    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    public Parameter1? Parameter { get; init; } 
    
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
        if (Parameter is Parameter1 ParameterValue)
        {
            writer.WriteStartElement(null, "Param", xmlNamespace );
            ParameterValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AlgorithmIdentification10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
