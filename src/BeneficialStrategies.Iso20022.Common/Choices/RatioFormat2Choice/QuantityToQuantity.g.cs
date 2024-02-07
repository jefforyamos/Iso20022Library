﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _Rj3khNp-Ed-ak6NoX_4Aeg_1125895682.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice;

/// <summary>
/// The ratio is expressed as a quantity per another quantity.
/// </summary>
public partial record QuantityToQuantity : RatioFormat2Choice_
     , IIsoXmlSerilizable<QuantityToQuantity>
{
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    public required IsoDecimalNumber Quantity1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    public required IsoDecimalNumber Quantity2 { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity1)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty2", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity2)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new QuantityToQuantity Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
