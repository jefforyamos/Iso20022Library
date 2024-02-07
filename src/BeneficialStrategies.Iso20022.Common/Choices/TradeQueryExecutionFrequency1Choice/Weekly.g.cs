﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Weekly.  ISO2002 ID# _lyvAwNGYEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TradeQueryExecutionFrequency1Choice;

/// <summary>
/// Query is executed on a weekly basis. The day of the week for the query execution should be specified.
/// </summary>
public partial record Weekly : TradeQueryExecutionFrequency1Choice_
     , IIsoXmlSerilizable<Weekly>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the day of the week of the delivery.
    /// </summary>
    public required WeekDay2Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Wkly", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Weekly Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
