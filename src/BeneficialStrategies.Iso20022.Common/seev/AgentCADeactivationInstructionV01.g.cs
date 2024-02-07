﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCADeactivationInstructionV01.  ISO2002 ID# _TMHRHdEwEd-BzquC8wXy7w_1150162088.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.seev.AgentCADeactivationInstructionV01>;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// This record is an implementation of the seev.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to instruct the deactivation of a corporate action event or to deactivate one or more specific options of the corporate action. As of the deactivation date, the CSD is allowed to reject any related election instruction received from clients.
/// Usage
/// Deactivation refers only to the empowerment of the CSD to reject further elections. To withdraw an event, the Agent Corporate Action Notification Advice message must be used.
/// This message can be used to deactivate all the options of a corporate action event, in which case, no option should be mentioned in the message.
/// This message can also be used to deactivate one or more specific corporate action options, in which case, the option type and option number must be present.
/// This message can only be used when the deactivation date is after the market deadline. Before the market deadline, an updated notification advice message must be sent with option availability status: inactive or cancelled.
/// An un-effected deactivation (pending deactivation date/time) can be cancelled with an Agent Corporate Action Deactivation Cancellation Request.
/// The amendment of a deactivation is effected by cancel/replace mechanism.
/// </summary>
[Serializable]
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to instruct the deactivation of a corporate action event or to deactivate one or more specific options of the corporate action. As of the deactivation date, the CSD is allowed to reject any related election instruction received from clients.|Usage|Deactivation refers only to the empowerment of the CSD to reject further elections. To withdraw an event, the Agent Corporate Action Notification Advice message must be used.|This message can be used to deactivate all the options of a corporate action event, in which case, no option should be mentioned in the message.|This message can also be used to deactivate one or more specific corporate action options, in which case, the option type and option number must be present.|This message can only be used when the deactivation date is after the market deadline. Before the market deadline, an updated notification advice message must be sent with option availability status: inactive or cancelled.|An un-effected deactivation (pending deactivation date/time) can be cancelled with an Agent Corporate Action Deactivation Cancellation Request.|The amendment of a deactivation is effected by cancel/replace mechanism.")]
public partial record AgentCADeactivationInstructionV01 : IOuterRecord<AgentCADeactivationInstructionV01,AgentCADeactivationInstructionV01Document>
    ,IIsoXmlSerilizable<AgentCADeactivationInstructionV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.028.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADeactvtnInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AgentCADeactivationInstructionV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_TMQbANEwEd-BzquC8wXy7w_-840620052")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the instruction.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification8 Identification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMQbAdEwEd-BzquC8wXy7w_-1767832374")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information related to the deactivation of a CA event.
    /// </summary>
    [IsoId("_TMQbAtEwEd-BzquC8wXy7w_-1426185033")]
    [Description(@"Information related to the deactivation of a CA event.")]
    [DataMember(Name="DeactvtnDtls")]
    [XmlElement(ElementName="DeactvtnDtls")]
    [Required]
    public required CorporateActionDeactivationInstruction1 DeactivationDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCADeactivationInstructionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCADeactivationInstructionV01Document ToDocument()
    {
        return new AgentCADeactivationInstructionV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AgtCADeactvtnInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CorpActnGnlInf", xmlNamespace );
        CorporateActionGeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DeactvtnDtls", xmlNamespace );
        DeactivationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static AgentCADeactivationInstructionV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCADeactivationInstructionV01"/>.
/// </summary>
[Serializable]
public partial record AgentCADeactivationInstructionV01Document : IOuterDocument<AgentCADeactivationInstructionV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.028.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCADeactivationInstructionV01"/> is required.
    /// </summary>
    [DataMember(Name=AgentCADeactivationInstructionV01.XmlTag)]
    public required AgentCADeactivationInstructionV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AgentCADeactivationInstructionV01.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
