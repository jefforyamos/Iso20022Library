﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _Tfp1KrKdEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus55Choice;

/// <summary>
/// Reason why the meeting instruction message or the individual meeting instruction is pending.
/// </summary>
public partial record Reason : PendingStatus55Choice_
     , IIsoXmlSerilizable<Reason>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    public required PendingReason51Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "RsnCd", xmlNamespace );
        ReasonCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoMax350Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalReasonInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Reason Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
