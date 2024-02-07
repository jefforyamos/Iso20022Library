﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RTGS.  ISO2002 ID# _72FYFaMgEeCJ6YNENx4h-w_1406028569.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode5Choice;

/// <summary>
/// Qualifies further the RTGS status.
/// </summary>
public partial record RTGS : PaymentStatusCode5Choice_
     , IIsoXmlSerilizable<RTGS>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies an alphanumeric string with a maximum length of 4 characters.
    /// </summary>
    public required IsoMax4AlphaNumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "RTGS", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax4AlphaNumericText(Value)); // data type Max4AlphaNumericText System.String
        writer.WriteEndElement();
    }
    public static new RTGS Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
