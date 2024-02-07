﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _ZxnU1cEcEea7jLfvGi1PDw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification3Choice;

/// <summary>
/// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
/// </summary>
public partial record LEI : CounterpartyIdentification3Choice_
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
