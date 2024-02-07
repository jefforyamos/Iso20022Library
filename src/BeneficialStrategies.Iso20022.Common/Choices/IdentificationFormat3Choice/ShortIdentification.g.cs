﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ShortIdentification.  ISO2002 ID# _qmP-cUEFEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat3Choice;

/// <summary>
/// Format expressed as a short identification.
/// </summary>
public partial record ShortIdentification : IdentificationFormat3Choice_
     , IIsoXmlSerilizable<ShortIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies an upper case alphanumeric string with a length of three characters.
    /// </summary>
    public required IsoExact3UpperCaseAlphaNumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "ShrtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact3UpperCaseAlphaNumericText(Value)); // data type Exact3UpperCaseAlphaNumericText System.String
        writer.WriteEndElement();
    }
    public static new ShortIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
