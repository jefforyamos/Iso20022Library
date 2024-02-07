﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentCode.  ISO2002 ID# _uoAOcNP8EeK0PPbKncCqzA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther1Choice;

/// <summary>
/// Specifies the payment period in coded form and a number of days.
/// </summary>
public partial record PaymentCode : PaymentCodeOrOther1Choice_
     , IIsoXmlSerilizable<PaymentCode>
{
    #nullable enable
    
    /// <summary>
    /// Code for the payment.
    /// </summary>
    public required PaymentTime3Code Code { get; init; } 
    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    public IsoNumber? NumberOfDays { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        writer.WriteValue(Code.ToString()); // Enum value
        writer.WriteEndElement();
        if (NumberOfDays is IsoNumber NumberOfDaysValue)
        {
            writer.WriteStartElement(null, "NbOfDays", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDaysValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
    }
    public static new PaymentCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
