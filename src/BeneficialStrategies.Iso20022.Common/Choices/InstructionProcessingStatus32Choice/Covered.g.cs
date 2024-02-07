﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Covered.  ISO2002 ID# _mWrV0LtVEeilsanBGAzy4A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus32Choice;

/// <summary>
/// Protect Instruction has been full covered.
/// </summary>
public partial record Covered : InstructionProcessingStatus32Choice_
     , IIsoXmlSerilizable<Covered>
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
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
        writer.WriteValue(NoSpecifiedReason.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new Covered Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
