﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RequiredSecurityScheme.  ISO2002 ID# _3rN4AItHEeSxlKlAGYErFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice;

/// <summary>
/// Parameters to be used by the security scheme update command.
/// </summary>
public partial record RequiredSecurityScheme : ATMCommandParameters2Choice_
     , IIsoXmlSerilizable<RequiredSecurityScheme>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// </summary>
    public required ATMSecurityScheme2Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "ReqrdSctySchme", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new RequiredSecurityScheme Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
