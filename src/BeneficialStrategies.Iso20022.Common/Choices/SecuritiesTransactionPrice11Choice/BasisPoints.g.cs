﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BasisPoints.  ISO2002 ID# _MXso581VEem4K5qLxnWwMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice11Choice;

/// <summary>
/// Price expressed as basis points.
/// </summary>
public partial record BasisPoints : SecuritiesTransactionPrice11Choice_
     , IIsoXmlSerilizable<BasisPoints>
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
        writer.WriteStartElement(null, "BsisPts", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Value)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new BasisPoints Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
