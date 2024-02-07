﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectionStatus.  ISO2002 ID# _RWwVkdp-Ed-ak6NoX_4Aeg_-1258577092.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice;

/// <summary>
/// Status advising on the rejection of the instruction.
/// </summary>
public partial record RejectionStatus : InstructionStatus2Choice_
     , IIsoXmlSerilizable<RejectionStatus>
{
    #nullable enable
    
    /// <summary>
    /// Reason advising the rejection of the instruction.
    /// </summary>
    public required RejectionReason1Code Reason { get; init; } 
    /// <summary>
    /// This code can be used in case another reason is required.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        writer.WriteValue(Reason.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XtndedRsn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedReason)); // data type Extended350Code System.String
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static new RejectionStatus Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
