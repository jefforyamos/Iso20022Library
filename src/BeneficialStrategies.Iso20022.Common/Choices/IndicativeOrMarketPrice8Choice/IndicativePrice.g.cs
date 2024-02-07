﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndicativePrice.  ISO2002 ID# _P1ygUUGMEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice8Choice;

/// <summary>
/// Estimated price, for example, for valuation purposes.
/// </summary>
public partial record IndicativePrice : IndicativeOrMarketPrice8Choice_
     , IIsoXmlSerilizable<IndicativePrice>
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
    public static new IndicativePrice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
