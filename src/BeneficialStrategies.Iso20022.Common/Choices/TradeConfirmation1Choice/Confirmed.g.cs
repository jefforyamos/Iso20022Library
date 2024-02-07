﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Confirmed.  ISO2002 ID# _PZ43oA28EeWmAKKPnqYEVQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation1Choice;

/// <summary>
/// Indicates the type of contract confirmation.
/// </summary>
public partial record Confirmed : TradeConfirmation1Choice_
     , IIsoXmlSerilizable<Confirmed>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the contract was confirmed electronically or non-electronically.
    /// </summary>
    public required TradeConfirmationType1Code Type { get; init; } 
    /// <summary>
    /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
    /// </summary>
    public required IsoISODateTime TimeStamp { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TmStmp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(TimeStamp)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static new Confirmed Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
