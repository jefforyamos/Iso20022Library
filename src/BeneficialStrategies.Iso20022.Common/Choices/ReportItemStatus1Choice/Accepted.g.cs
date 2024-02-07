﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Accepted.  ISO2002 ID# _08aRY73QEeO2FLWuu_JIqg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReportItemStatus1Choice;

/// <summary>
/// Statement is accepted.
/// </summary>
public partial record Accepted : ReportItemStatus1Choice_
     , IIsoXmlSerilizable<Accepted>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies that there is no reason available.
    /// </summary>
    public required NoReasonCode Value { get; init; } 
    
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
        writer.WriteStartElement(null, "Accptd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Accepted Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
