﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketPrice.  ISO2002 ID# _ctkIB5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice11Choice;

/// <summary>
/// Last reported/known price of a financial instrument in a market.
/// </summary>
public partial record MarketPrice : IndicativeOrMarketPrice11Choice_
     , IIsoXmlSerilizable<MarketPrice>
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
    public static new MarketPrice Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
