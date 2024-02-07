﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDateTimeToDateTime.  ISO2002 ID# _T5exEtp-Ed-ak6NoX_4Aeg_-1058335325.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Period2Choice;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
public partial record FromDateTimeToDateTime : Period2Choice_
     , IIsoXmlSerilizable<FromDateTimeToDateTime>
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    public required IsoISODateTime FromDateTime { get; init; } 
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    public required IsoISODateTime ToDateTime { get; init; } 
    
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
        writer.WriteStartElement(null, "FrDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(FromDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ToDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ToDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static new FromDateTimeToDateTime Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
