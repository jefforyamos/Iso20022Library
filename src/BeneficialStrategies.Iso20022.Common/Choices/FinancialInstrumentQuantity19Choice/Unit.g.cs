﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _dPPy-_mWEeCcAY_zfcalaA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity19Choice;

/// <summary>
/// Quantity expressed as a number, for example, a number of shares.
/// </summary>
public partial record Unit : FinancialInstrumentQuantity19Choice_
     , IIsoXmlSerilizable<Unit>
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
        writer.WriteStartElement(null, "Unit", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(Value)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
    }
    public static new Unit Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
