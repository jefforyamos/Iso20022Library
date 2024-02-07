﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherMessageIdentification.  ISO2002 ID# _Wkm3nUfGEey6Is2iMqV8fg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References79Choice;

/// <summary>
/// Unambiguous identification of the message to be cancelled.
/// </summary>
public partial record OtherMessageIdentification : References79Choice_
     , IIsoXmlSerilizable<OtherMessageIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 16 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash "/" at the beginning and end of line and double slash "//" within the line.
    /// </summary>
    public required IsoRestrictedFINXMax16Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "OthrMsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(Value)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
    }
    public static new OtherMessageIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
