﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDate.  ISO2002 ID# _76joYKMgEeCJ6YNENx4h-w_-1958941273.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod2Choice;

/// <summary>
/// Date at which the range starts.
/// </summary>
public partial record FromDate : DateAndPeriod2Choice_
     , IIsoXmlSerilizable<FromDate>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in "XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004" which is aligned with ISO 8601.
    /// </summary>
    public required IsoISODate Value { get; init; } 
    
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
        writer.WriteStartElement(null, "FrDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(Value)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static new FromDate Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
