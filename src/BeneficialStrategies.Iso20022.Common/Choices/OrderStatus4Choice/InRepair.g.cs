﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InRepair.  ISO2002 ID# _9wxHy0H8EeaV3ab_pHzFIQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice;

/// <summary>
/// Status of the switch order is in repair.
/// </summary>
public partial record InRepair : OrderStatus4Choice_
     , IIsoXmlSerilizable<InRepair>
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
    public static new InRepair Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
