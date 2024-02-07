﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChargeBackInitiation.  ISO2002 ID# _toPaAFZWEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Chargeback initiation message record.
/// </summary>
public partial record ChargeBackInitiation : RecordMessage1Choice_
     , IIsoXmlSerilizable<ChargeBackInitiation>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Binary data of 2MB maximum.
    /// </summary>
    public required IsoMax2MBBinary Value { get; init; } 
    
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
        writer.WriteStartElement(null, "ChrgBckInitn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax2MBBinary(Value)); // data type Max2MBBinary System.Byte[]
        writer.WriteEndElement();
    }
    public static new ChargeBackInitiation Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
