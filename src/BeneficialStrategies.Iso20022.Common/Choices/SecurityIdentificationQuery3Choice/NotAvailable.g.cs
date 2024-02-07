﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotAvailable.  ISO2002 ID# _P-19BdGgEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery3Choice;

/// <summary>
/// Query for not available value (N/A).
/// Usage: N/A means that value was not available at the time of the reporting.
/// </summary>
public partial record NotAvailable : SecurityIdentificationQuery3Choice_
     , IIsoXmlSerilizable<NotAvailable>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a not available value code.
    /// </summary>
    public required NotAvailable1Code Value { get; init; } 
    
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
        writer.WriteStartElement(null, "NotAvlbl", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new NotAvailable Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
