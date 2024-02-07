﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareTerminationOption3.  ISO2002 ID# _9FbPUa5iEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a termination option.
/// </summary>
public partial record CompareTerminationOption3
     : IIsoXmlSerilizable<CompareTerminationOption3>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public RepoTerminationOption2Code? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public RepoTerminationOption2Code? Value2 { get; init; } 
    
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
        if (Value1 is RepoTerminationOption2Code Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            writer.WriteValue(Value1Value.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Value2 is RepoTerminationOption2Code Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            writer.WriteValue(Value2Value.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CompareTerminationOption3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
