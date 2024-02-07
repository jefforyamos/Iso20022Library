﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageItemCondition1.  ISO2002 ID# _K86DNH1DEeCF8NjrBemJWQ_-909229730.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Presence condition of a message item.
/// </summary>
public partial record MessageItemCondition1
     : IIsoXmlSerilizable<MessageItemCondition1>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the message and the message item.
    /// </summary>
    public required IsoMax140Text ItemIdentification { get; init; } 
    /// <summary>
    /// Condition of presence of the message item.
    /// </summary>
    public required MessageItemCondition1Code Condition { get; init; } 
    /// <summary>
    /// Value to be used for the message item.
    /// </summary>
    public IsoMax140Text? Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "ItmId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax140Text(ItemIdentification)); // data type Max140Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cond", xmlNamespace );
        writer.WriteValue(Condition.ToString()); // Enum value
        writer.WriteEndElement();
        if (Value is IsoMax140Text ValueValue)
        {
            writer.WriteStartElement(null, "Val", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ValueValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static MessageItemCondition1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
