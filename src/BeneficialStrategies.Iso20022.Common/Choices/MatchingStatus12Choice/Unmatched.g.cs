﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unmatched.  ISO2002 ID# _Ehhd7_7ZEeCtrO5qCU90cA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus12Choice;

/// <summary>
/// Status is unmatched.
/// </summary>
public partial record Unmatched : MatchingStatus12Choice_
     , IIsoXmlSerilizable<Unmatched>
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
    public static new Unmatched Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
