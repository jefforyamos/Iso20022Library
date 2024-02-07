﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Valoren.  ISO2002 ID# _CSq4RyGQEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice;

/// <summary>
/// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
/// </summary>
public partial record Valoren : SecurityIdentification23Choice_
     , IIsoXmlSerilizable<Valoren>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
    /// </summary>
    public required IsoValorenIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Vlrn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoValorenIdentifier(Value)); // data type ValorenIdentifier System.String
        writer.WriteEndElement();
    }
    public static new Valoren Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
