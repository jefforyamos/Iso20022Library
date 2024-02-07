﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OnVenue.  ISO2002 ID# _upJw4Hy7Eeu1BeE84IrnAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueType1Choice;

/// <summary>
/// Whether the Securities Financing Transaction was concluded on a domestic trading venue or a foregin trading venue.
/// </summary>
public partial record OnVenue : TradingVenueType1Choice_
     , IIsoXmlSerilizable<OnVenue>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a code for a trade market.
    /// </summary>
    public required TradeMarket2Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "OnVn", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new OnVenue Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
