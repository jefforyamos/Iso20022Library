﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _UWYvcdp-Ed-ak6NoX_4Aeg_841777270.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus2Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : AcknowledgedAcceptedStatus2Choice_
     , IIsoXmlSerilizable<NoSpecifiedReason>
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
        writer.WriteStartElement(null, "NoSpcfdRsn", xmlNamespace );
        writer.WriteValue(Value.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new NoSpecifiedReason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
