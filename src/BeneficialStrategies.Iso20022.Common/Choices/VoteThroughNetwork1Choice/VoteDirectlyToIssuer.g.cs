﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VoteDirectlyToIssuer.  ISO2002 ID# _LM16IDT8Ee2tRf29bleifQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.VoteThroughNetwork1Choice;

/// <summary>
/// Voting is performed by sending a vote message directly to the issuer. 
/// </summary>
public partial record VoteDirectlyToIssuer : VoteThroughNetwork1Choice_
     , IIsoXmlSerilizable<VoteDirectlyToIssuer>
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
        writer.WriteStartElement(null, "VoteDrctlyToIssr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoAnyBICDec2014Identifier(Value)); // data type AnyBICDec2014Identifier System.String
        writer.WriteEndElement();
    }
    public static new VoteDirectlyToIssuer Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
