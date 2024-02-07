﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityToQuantityRatio1.  ISO2002 ID# _UMjeDdp-Ed-ak6NoX_4Aeg_-130090445.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
public partial record QuantityToQuantityRatio1
     : IIsoXmlSerilizable<QuantityToQuantityRatio1>
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Qty1", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity1)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty2", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Quantity2)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static QuantityToQuantityRatio1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
