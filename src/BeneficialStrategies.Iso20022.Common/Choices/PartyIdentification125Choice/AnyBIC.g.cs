﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _e8twA2pTEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification125Choice;

/// <summary>
/// Identification of the party expressed as a BIC.
/// </summary>
public partial record AnyBIC : PartyIdentification125Choice_
     , IIsoXmlSerilizable<AnyBIC>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362: 2014 - "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public required IsoAnyBICDec2014Identifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "AnyBIC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoAnyBICDec2014Identifier(Value)); // data type AnyBICDec2014Identifier System.String
        writer.WriteEndElement();
    }
    public static new AnyBIC Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
