﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _yR4C7UEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat38Choice;

/// <summary>
/// Price expressed in index points.
/// </summary>
public partial record IndexPoints : RateAndAmountFormat38Choice_
     , IIsoXmlSerilizable<IndexPoints>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
    /// </summary>
    public required IsoDecimalNumber Value { get; init; } 
    
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
        writer.WriteStartElement(null, "IndxPts", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Value)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new IndexPoints Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
