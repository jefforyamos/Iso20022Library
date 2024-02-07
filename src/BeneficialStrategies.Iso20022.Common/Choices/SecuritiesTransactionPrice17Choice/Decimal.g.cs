﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Decimal.  ISO2002 ID# _gSTIiZjcEeqkLZLH6DK3UQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice;

/// <summary>
/// </summary>
public partial record Decimal : SecuritiesTransactionPrice17Choice_
     , IIsoXmlSerilizable<Decimal>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Rate expressed as a decimal, for example, 0.7 is 7/10 and 70%.
    /// </summary>
    public required IsoBaseOneRate Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Dcml", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoBaseOneRate(Value)); // data type BaseOneRate System.Decimal
        writer.WriteEndElement();
    }
    public static new Decimal Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
