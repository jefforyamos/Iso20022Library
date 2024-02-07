﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _ckBxuZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat21Choice;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
public partial record QuantityToQuantity : RatioFormat21Choice_
     , IIsoXmlSerilizable<QuantityToQuantity>
{
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; } 
    
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
        writer.WriteStartElement(null, "Qty1", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINDecimalNumber(Quantity1)); // data type RestrictedFINDecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty2", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINDecimalNumber(Quantity2)); // data type RestrictedFINDecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new QuantityToQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
