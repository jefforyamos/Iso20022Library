﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraBalanceMovementIdentification.  ISO2002 ID# _5Pat75NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References50Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
public partial record IntraBalanceMovementIdentification : References50Choice_
     , IIsoXmlSerilizable<IntraBalanceMovementIdentification>
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
        writer.WriteStartElement(null, "IntraBalMvmntId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(Value)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
    }
    public static new IntraBalanceMovementIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
