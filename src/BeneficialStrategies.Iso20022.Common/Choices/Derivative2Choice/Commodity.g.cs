﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Commodity.  ISO2002 ID# _Bv9MQWkwEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice;

/// <summary>
/// Details specific for commodity derivatives.
/// </summary>
public partial record Commodity : Derivative2Choice_
     , IIsoXmlSerilizable<Commodity>
{
    #nullable enable
    
    /// <summary>
    /// Provides specific information related to commodity derivatives.
    /// </summary>
    public CommodityDerivate2Choice_? ClassSpecific { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    
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
        if (ClassSpecific is CommodityDerivate2Choice_ ClassSpecificValue)
        {
            writer.WriteStartElement(null, "ClssSpcfc", xmlNamespace );
            ClassSpecificValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NtnlCcy", xmlNamespace );
        writer.WriteValue(NotionalCurrency.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Commodity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
