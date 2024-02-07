﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Strategy.  ISO2002 ID# _u_O2MKswEeayv9XxdmMwKQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.StressItem1Choice;

/// <summary>
/// Assumed stress move for a set of financial instruments defined by a common trading strategy.
/// </summary>
public partial record Strategy : StressItem1Choice_
     , IIsoXmlSerilizable<Strategy>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for the strategy.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Assumed stress move of the associated stress item under the scenario.
    /// </summary>
    public required StressSize1Choice_ StressSize { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StrssSz", xmlNamespace );
        StressSize.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new Strategy Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
