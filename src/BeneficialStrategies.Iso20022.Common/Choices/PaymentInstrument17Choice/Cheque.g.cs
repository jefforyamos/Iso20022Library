﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cheque.  ISO2002 ID# _t7vvIBdHEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument17Choice;

/// <summary>
/// Indicates whether the payment is done via cheque.
/// </summary>
public partial record Cheque : PaymentInstrument17Choice_
     , IIsoXmlSerilizable<Cheque>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Indicates a "Yes" or "No" type of answer for an element.
    /// </summary>
    public required IsoYesNoIndicator Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Chq", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Value)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static new Cheque Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
