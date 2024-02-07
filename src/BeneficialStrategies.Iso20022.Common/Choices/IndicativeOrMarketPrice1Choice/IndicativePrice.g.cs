﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndicativePrice.  ISO2002 ID# _UKwuQ9p-Ed-ak6NoX_4Aeg_-1205110584.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice1Choice;

/// <summary>
/// Estimated price, for example, for valuation purposes.
/// </summary>
public partial record IndicativePrice : IndicativeOrMarketPrice1Choice_
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
