﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Description.  ISO2002 ID# _04Bcawk_EeGQpPnjvNlciw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification4Choice;

/// <summary>
/// Description of the market when no Market Identifier Code is available.
/// </summary>
public partial record Description : MarketIdentification4Choice_
     , IIsoXmlSerilizable<Description>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 30 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash "/" at the beginning and end of line and double slash "//" within the line.
    /// </summary>
    public required IsoRestrictedFINXMax30Text Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Desc", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax30Text(Value)); // data type RestrictedFINXMax30Text System.String
        writer.WriteEndElement();
    }
    public static new Description Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
