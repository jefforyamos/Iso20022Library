﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BinaryValue.  ISO2002 ID# _4EhKp5aNEemfCcEf5rVTyg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice;

/// <summary>
/// Value of the data expressed in BASE-64 encoded binary form.
/// </summary>
public partial record BinaryValue : VerificationValue1Choice_
     , IIsoXmlSerilizable<BinaryValue>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a binary string with a maximum length of 5000 binary bytes.
    /// </summary>
    public required IsoMax5000Binary Value { get; init; } 
    
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
        writer.WriteStartElement(null, "BinryVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax5000Binary(Value)); // data type Max5000Binary System.Byte[]
        writer.WriteEndElement();
    }
    public static new BinaryValue Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
