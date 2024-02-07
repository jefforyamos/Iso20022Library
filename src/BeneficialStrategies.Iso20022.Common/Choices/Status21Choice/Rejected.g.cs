﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _MHhOUSYuEeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Status21Choice;

/// <summary>
/// Status of the transfer cancellation is rejected.
/// </summary>
public partial record Rejected : Status21Choice_
     , IIsoXmlSerilizable<Rejected>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public required RejectedReason17Choice_ Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected status reason.
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        Reason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalReasonInformation is IsoMax350Text AdditionalReasonInformationValue)
        {
            writer.WriteStartElement(null, "AddtlRsnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalReasonInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Rejected Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
