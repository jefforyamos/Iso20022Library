﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _RE37Zdp-Ed-ak6NoX_4Aeg_-1060377579.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat1Choice;

/// <summary>
/// Date expressed as a calendar date.
/// </summary>
public partial record Date : DateFormat1Choice_
     , IIsoXmlSerilizable<Date>
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
        writer.WriteStartElement(null, "Dt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(Value)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static new Date Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
