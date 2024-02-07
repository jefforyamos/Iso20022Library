﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _TRuNgLXLEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification129Choice;

/// <summary>
/// Legal entity identification of the party.
/// </summary>
public partial record LEI : PartyIdentification129Choice_
     , IIsoXmlSerilizable<LEI>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public required IsoLEIIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "LEI", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(Value)); // data type LEIIdentifier System.String
        writer.WriteEndElement();
    }
    public static new LEI Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
