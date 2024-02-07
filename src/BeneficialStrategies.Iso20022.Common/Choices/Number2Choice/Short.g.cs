﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Short.  ISO2002 ID# _Qu0y5dp-Ed-ak6NoX_4Aeg_-630213750.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Number2Choice;

/// <summary>
/// Number of maximum 3 numeric text.
/// </summary>
public partial record Short : Number2Choice_
     , IIsoXmlSerilizable<Short>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a numeric string with an exact length of 3 digits.
    /// </summary>
    public required IsoExact3NumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Shrt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact3NumericText(Value)); // data type Exact3NumericText System.String
        writer.WriteEndElement();
    }
    public static new Short Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
