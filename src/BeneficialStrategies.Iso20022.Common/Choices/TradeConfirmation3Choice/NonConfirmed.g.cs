﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonConfirmed.  ISO2002 ID# _PQNwE1o3Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation3Choice;

/// <summary>
/// Indicates that contract was not confirmed.
/// </summary>
public partial record NonConfirmed : TradeConfirmation3Choice_
     , IIsoXmlSerilizable<NonConfirmed>
{
    #nullable enable
    
    /// <summary>
    /// Specifies that the contract remains unconfirmed.
    /// </summary>
    public required TradeConfirmationType2Code Type { get; init; } 
    
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
    }
    public static new NonConfirmed Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
