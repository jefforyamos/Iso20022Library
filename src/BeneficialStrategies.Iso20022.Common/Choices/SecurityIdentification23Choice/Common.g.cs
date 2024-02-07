﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Common.  ISO2002 ID# _CSq4TSGQEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice;

/// <summary>
/// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
/// </summary>
public partial record Common : SecurityIdentification23Choice_
     , IIsoXmlSerilizable<Common>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
    /// </summary>
    public required IsoEuroclearClearstreamIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Cmon", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoEuroclearClearstreamIdentifier(Value)); // data type EuroclearClearstreamIdentifier System.String
        writer.WriteEndElement();
    }
    public static new Common Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
