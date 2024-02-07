﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NumberOfDays.  ISO2002 ID# _VnGekzqwEeWZFYSPlduMhw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CashAvailabilityDate1Choice;

/// <summary>
/// Indicates the number of float days attached to the balance.
/// </summary>
public partial record NumberOfDays : CashAvailabilityDate1Choice_
     , IIsoXmlSerilizable<NumberOfDays>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a numeric string with a maximum length of 15 digits and may be prefixed with a plus sign.
    /// </summary>
    public required IsoMax15PlusSignedNumericText Value { get; init; } 
    
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
        writer.WriteStartElement(null, "NbOfDays", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15PlusSignedNumericText(Value)); // data type Max15PlusSignedNumericText System.String
        writer.WriteEndElement();
    }
    public static new NumberOfDays Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
