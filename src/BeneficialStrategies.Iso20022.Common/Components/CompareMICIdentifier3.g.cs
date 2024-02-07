﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareMICIdentifier3.  ISO2002 ID# _3899Ma5hEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a MIC (Market Identifier Code-ISO10383) identifier.
/// </summary>
public partial record CompareMICIdentifier3
     : IIsoXmlSerilizable<CompareMICIdentifier3>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IsoMICIdentifier? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IsoMICIdentifier? Value2 { get; init; } 
    
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
        if (Value1 is IsoMICIdentifier Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(Value1Value)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
        if (Value2 is IsoMICIdentifier Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(Value2Value)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static CompareMICIdentifier3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
