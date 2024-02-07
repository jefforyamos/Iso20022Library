﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateTime.  ISO2002 ID# _T6OX6dp-Ed-ak6NoX_4Aeg_1215657156.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DateAndDateTimeChoice;

/// <summary>
/// Specified date and time.
/// </summary>
public partial record DateTime : DateAndDateTimeChoice_
     , IIsoXmlSerilizable<DateTime>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
    /// </summary>
    public required IsoISODateTime Value { get; init; } 
    
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
        writer.WriteStartElement(null, "DtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(Value)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static new DateTime Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
