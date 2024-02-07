﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Pending.  ISO2002 ID# _ym2jx5M6EemKz5EOjv82iQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status31Choice;

/// <summary>
/// Status of the transfer cancellation is pending.
/// </summary>
public partial record Pending : Status31Choice_
     , IIsoXmlSerilizable<Pending>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancellation pending status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    
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
        if (Reason is IsoMax350Text ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(ReasonValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Pending Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
