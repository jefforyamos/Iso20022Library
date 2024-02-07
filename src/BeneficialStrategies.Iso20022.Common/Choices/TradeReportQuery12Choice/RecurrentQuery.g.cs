﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RecurrentQuery.  ISO2002 ID# _QG7io65pEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery12Choice;

/// <summary>
/// Query criteria specifically applied to recurrent queries.
/// </summary>
public partial record RecurrentQuery : TradeReportQuery12Choice_
     , IIsoXmlSerilizable<RecurrentQuery>
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of recurrent query which is requested.
    /// </summary>
    public required IsoMax1000Text QueryType { get; init; } 
    /// <summary>
    /// Defines the requested frequency of the recurrent query.
    /// </summary>
    public required TradeQueryExecutionFrequency3 Frequency { get; init; } 
    /// <summary>
    /// Defines the date until which the query will be executed.
    /// </summary>
    public required IsoISODate ValidUntil { get; init; } 
    
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
        writer.WriteStartElement(null, "QryTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax1000Text(QueryType)); // data type Max1000Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Frqcy", xmlNamespace );
        Frequency.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "VldUntil", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValidUntil)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static new RecurrentQuery Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
