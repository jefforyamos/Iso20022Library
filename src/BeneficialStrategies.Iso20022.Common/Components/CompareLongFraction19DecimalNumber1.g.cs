﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareLongFraction19DecimalNumber1.  ISO2002 ID# _7PX6cExUEeywvc16MwOPfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a number field represented as a 19 decimals.
/// </summary>
public partial record CompareLongFraction19DecimalNumber1
     : IIsoXmlSerilizable<CompareLongFraction19DecimalNumber1>
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Value2 { get; init; } 
    
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
        if (Value1 is IsoLongFraction19DecimalNumber Value1Value)
        {
            writer.WriteStartElement(null, "Val1", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLongFraction19DecimalNumber(Value1Value)); // data type LongFraction19DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (Value2 is IsoLongFraction19DecimalNumber Value2Value)
        {
            writer.WriteStartElement(null, "Val2", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLongFraction19DecimalNumber(Value2Value)); // data type LongFraction19DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
    }
    public static CompareLongFraction19DecimalNumber1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
