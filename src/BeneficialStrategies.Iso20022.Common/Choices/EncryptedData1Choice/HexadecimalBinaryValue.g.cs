﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HexadecimalBinaryValue.  ISO2002 ID# _-on81ekLEemeDPHh-U9b6w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.EncryptedData1Choice;

/// <summary>
/// Hexadecimal binary encoded encrypted data.
/// </summary>
public partial record HexadecimalBinaryValue : EncryptedData1Choice_
     , IIsoXmlSerilizable<HexadecimalBinaryValue>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 9999 binary bytes (19998 hexadecimal text characters).
    /// Used only for hex binary data only, supports only characters A-F and 0-9.
    /// </summary>
    public required IsoMax9999HexBinaryText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "HexBinryVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax9999HexBinaryText(Value)); // data type Max9999HexBinaryText System.String
        writer.WriteEndElement();
    }
    public static new HexadecimalBinaryValue Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
