﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CaseStatusReportV03.  ISO2002 ID# _PzltuNE-Ed-BzquC8wXy7w_86849110.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.CaseStatusReportV03>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.039.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Case Status Report message is sent by a case assignee to a case creator or case assigner.
/// This message is used to report on the status of a case.
/// Usage
/// A Case Status Report message is sent in reply to a Case Status Report Request message. This message
/// - covers one and only one case at a time. (If a case assignee needs to report on several cases, then multiple Case Status Report messages must be sent.)
/// - may be forwarded to subsequent case assigner(s) until it reaches the end point
/// - is able to indicate the fact that a case has been assigned to a party downstream in the payment processing chain
/// - may not be used in place of a Resolution Of Investigation (except for the condition given in the next bullet point) or Notification Of Case Assignment message
/// - may be skipped and replaced by a Resolution Of Investigation message when the request for a investigation status is received at the time the assigner has resolved the case. (In this case a Resolution Of Investigation message can be sent instead of a Case Status Report and the case may be closed.).
/// </summary>
[Serializable]
[Description(@"Scope|The Case Status Report message is sent by a case assignee to a case creator or case assigner.|This message is used to report on the status of a case.|Usage|A Case Status Report message is sent in reply to a Case Status Report Request message. This message|- covers one and only one case at a time. (If a case assignee needs to report on several cases, then multiple Case Status Report messages must be sent.)|- may be forwarded to subsequent case assigner(s) until it reaches the end point|- is able to indicate the fact that a case has been assigned to a party downstream in the payment processing chain|- may not be used in place of a Resolution Of Investigation (except for the condition given in the next bullet point) or Notification Of Case Assignment message|- may be skipped and replaced by a Resolution Of Investigation message when the request for a investigation status is received at the time the assigner has resolved the case. (In this case a Resolution Of Investigation message can be sent instead of a Case Status Report and the case may be closed.).")]
public partial record CaseStatusReportV03 : IOuterRecord<CaseStatusReportV03,CaseStatusReportV03Document>
    ,IIsoXmlSerilizable<CaseStatusReportV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.039.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CaseStsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CaseStatusReportV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Specifies generic information about an investigation report.
    /// </summary>
    [IsoId("_PzltudE-Ed-BzquC8wXy7w_108164602")]
    [Description(@"Specifies generic information about an investigation report.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required ReportHeader2 Header { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_Pzu3oNE-Ed-BzquC8wXy7w_108164624")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case2 Case { get; init; }
    
    /// <summary>
    /// Defines the status of the case.
    /// </summary>
    [IsoId("_Pzu3odE-Ed-BzquC8wXy7w_86849420")]
    [Description(@"Defines the status of the case.")]
    [DataMember(Name="Sts")]
    [XmlElement(ElementName="Sts")]
    [Required]
    public required CaseStatus2 Status { get; init; }
    
    /// <summary>
    /// Identifies the change of an assignment for an investigation case from an assigner to a new assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_Pzu3otE-Ed-BzquC8wXy7w_108164716")]
    [Description(@"Identifies the change of an assignment for an investigation case from an assigner to a new assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="NewAssgnmt")]
    [XmlElement(ElementName="NewAssgnmt")]
    public CaseAssignment2? NewAssignment { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CaseStatusReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CaseStatusReportV03Document ToDocument()
    {
        return new CaseStatusReportV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CaseStsRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Hdr", xmlNamespace );
        Header.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Case", xmlNamespace );
        Case.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        Status.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NewAssignment is CaseAssignment2 NewAssignmentValue)
        {
            writer.WriteStartElement(null, "NewAssgnmt", xmlNamespace );
            NewAssignmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CaseStatusReportV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CaseStatusReportV03"/>.
/// </summary>
[Serializable]
public partial record CaseStatusReportV03Document : IOuterDocument<CaseStatusReportV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.039.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CaseStatusReportV03"/> is required.
    /// </summary>
    [DataMember(Name=CaseStatusReportV03.XmlTag)]
    public required CaseStatusReportV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CaseStatusReportV03.XmlTag);
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
