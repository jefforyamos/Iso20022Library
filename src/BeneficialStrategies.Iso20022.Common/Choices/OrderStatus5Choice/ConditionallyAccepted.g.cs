﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ConditionallyAccepted.  ISO2002 ID# _P8YAmUHREeasdbKMiqizqA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice;

/// <summary>
/// Status of the individual order is conditionally accepted.
/// </summary>
public partial record ConditionallyAccepted : OrderStatus5Choice_
     , IIsoXmlSerilizable<ConditionallyAccepted>
{
    #nullable enable
    
    
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
    }
    public static new ConditionallyAccepted Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
