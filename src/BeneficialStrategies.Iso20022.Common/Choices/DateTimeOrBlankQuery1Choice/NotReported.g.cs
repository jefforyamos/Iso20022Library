﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotReported.  ISO2002 ID# _HaZjo2E4Ee2S65ml6YCOtA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DateTimeOrBlankQuery1Choice;

/// <summary>
/// Field may be queried for not reported value.
/// </summary>
public partial record NotReported : DateTimeOrBlankQuery1Choice_
     , IIsoXmlSerilizable<NotReported>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a not reported value code.
    /// </summary>
    public required NotReported1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "NotRptd", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new NotReported Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
