﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IdentificationAssignment3.  ISO2002 ID# _QIQa4W49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification assignment.
/// </summary>
public partial record IdentificationAssignment3
     : IIsoXmlSerilizable<IdentificationAssignment3>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the identification assignment was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Party that created the identification assignment.
    /// </summary>
    public Party40Choice_? Creator { get; init; } 
    /// <summary>
    /// Identifies the first agent in the identification chain, following the payment initiating party.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? FirstAgent { get; init; } 
    /// <summary>
    /// Party that assigns the identification assignment to another party. This is also the sender of the message.
    /// </summary>
    public required Party40Choice_ Assigner { get; init; } 
    /// <summary>
    /// Party that the identification assignment is assigned to. This is also the receiver of the message.
    /// </summary>
    public required Party40Choice_ Assignee { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (Creator is Party40Choice_ CreatorValue)
        {
            writer.WriteStartElement(null, "Cretr", xmlNamespace );
            CreatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FirstAgent is BranchAndFinancialInstitutionIdentification6 FirstAgentValue)
        {
            writer.WriteStartElement(null, "FrstAgt", xmlNamespace );
            FirstAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Assgnr", xmlNamespace );
        Assigner.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Assgne", xmlNamespace );
        Assignee.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static IdentificationAssignment3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
