﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FINMessageType.  ISO2002 ID# _RIwV1dp-Ed-ak6NoX_4Aeg_1910593546.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentOrigin1Choice;

/// <summary>
/// Specifies that the payment was included in a SWIFT FIN format message, for example, MT 103.
/// </summary>
public partial record FINMessageType : PaymentOrigin1Choice_
     , IIsoXmlSerilizable<FINMessageType>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a numeric string with a maximum length of 3 digits.
    /// </summary>
    public required IsoMax3NumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "FINMT", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax3NumericText(Value)); // data type Max3NumericText System.String
        writer.WriteEndElement();
    }
    public static new FINMessageType Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
