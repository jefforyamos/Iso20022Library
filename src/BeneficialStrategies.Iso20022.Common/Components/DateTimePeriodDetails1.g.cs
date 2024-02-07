﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DateTimePeriodDetails1.  ISO2002 ID# _T5xr8dp-Ed-ak6NoX_4Aeg_-1128572161.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
public partial record DateTimePeriodDetails1
     : IIsoXmlSerilizable<DateTimePeriodDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    public required IsoISODateTime FromDateTime { get; init; } 
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    public IsoISODateTime? ToDateTime { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "FrDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(FromDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (ToDateTime is IsoISODateTime ToDateTimeValue)
        {
            writer.WriteStartElement(null, "ToDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ToDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static DateTimePeriodDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
