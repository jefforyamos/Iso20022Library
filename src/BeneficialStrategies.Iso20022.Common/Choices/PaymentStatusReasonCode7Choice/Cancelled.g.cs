﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancelled.  ISO2002 ID# _Ny9Dw5lPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice;

/// <summary>
/// Reason why the payment status is cancelled.
/// </summary>
public partial record Cancelled : PaymentStatusReasonCode7Choice_
     , IIsoXmlSerilizable<Cancelled>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the underlying reason for cancellation of the associated transaction.
    /// </summary>
    public required CancelledStatusReason1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Canc", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Cancelled Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
