﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ResolutionOfInvestigationV09.  ISO2002 ID# _eX_OZ22PEei3KuUgpx7Xcw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.ResolutionOfInvestigationV09>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.029.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee;
/// - information on the return where applicable.
/// Usage
/// The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The ResolutionOfInvestigation message provides:
/// - the final outcome of the case, whether positive or negative;
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return.
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The ResolutionOfInvestigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator;
/// - not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message.
/// Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.
/// The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.
/// </summary>
[Serializable]
[Description(@"Scope|The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee;|- information on the return where applicable.|Usage|The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The ResolutionOfInvestigation message provides:|- the final outcome of the case, whether positive or negative;|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return.|Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.|The ResolutionOfInvestigation message must:|- be forwarded by all subsequent case assignee(s) until it reaches the case creator;|- not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message.|Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.|The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.")]
public partial record ResolutionOfInvestigationV09 : IOuterRecord<ResolutionOfInvestigationV09,ResolutionOfInvestigationV09Document>
    ,IIsoXmlSerilizable<ResolutionOfInvestigationV09>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.029.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ResolutionOfInvestigationV09Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_Oc22PEei3KuUgpx7Xcw")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Identifies a resolved case.
    /// </summary>
    [IsoId("_eX_OdW2PEei3KuUgpx7Xcw")]
    [Description(@"Identifies a resolved case.")]
    [DataMember(Name="RslvdCase")]
    [XmlElement(ElementName="RslvdCase")]
    public Case5? ResolvedCase { get; init; }
    
    /// <summary>
    /// Indicates the status of the investigation.
    /// </summary>
    [IsoId("_eX_Od22PEei3KuUgpx7Xcw")]
    [Description(@"Indicates the status of the investigation.")]
    [DataMember(Name="Sts")]
    [XmlElement(ElementName="Sts")]
    [Required]
    public required InvestigationStatus5Choice_ Status { get; init; }
    
    /// <summary>
    /// Specifies the details of the underlying transactions being cancelled.
    /// </summary>
    [IsoId("_eX_OeW2PEei3KuUgpx7Xcw")]
    [Description(@"Specifies the details of the underlying transactions being cancelled.")]
    [DataMember(Name="CxlDtls")]
    [XmlElement(ElementName="CxlDtls")]
    public UnderlyingTransaction22? CancellationDetails { get; init; }
    
    /// <summary>
    /// Specifies the details of the underlying transaction being modified.
    /// </summary>
    [IsoId("_eX_Oe22PEei3KuUgpx7Xcw")]
    [Description(@"Specifies the details of the underlying transaction being modified.")]
    [DataMember(Name="ModDtls")]
    [XmlElement(ElementName="ModDtls")]
    public PaymentTransaction107? ModificationDetails { get; init; }
    
    /// <summary>
    /// Specifies the details of the underlying transaction for which a claim non receipt has been initiated.
    /// </summary>
    [IsoId("_eX_OfW2PEei3KuUgpx7Xcw")]
    [Description(@"Specifies the details of the underlying transaction for which a claim non receipt has been initiated.")]
    [DataMember(Name="ClmNonRctDtls")]
    [XmlElement(ElementName="ClmNonRctDtls")]
    public ClaimNonReceipt2Choice_? ClaimNonReceiptDetails { get; init; }
    
    /// <summary>
    /// Details on the underlying statement entry.
    /// </summary>
    [IsoId("_eX_Of22PEei3KuUgpx7Xcw")]
    [Description(@"Details on the underlying statement entry.")]
    [DataMember(Name="StmtDtls")]
    [XmlElement(ElementName="StmtDtls")]
    public StatementResolutionEntry4? StatementDetails { get; init; }
    
    /// <summary>
    /// References a transaction initiated to fix the case under investigation.
    /// </summary>
    [IsoId("_eX_OgW2PEei3KuUgpx7Xcw")]
    [Description(@"References a transaction initiated to fix the case under investigation.")]
    [DataMember(Name="CrrctnTx")]
    [XmlElement(ElementName="CrrctnTx")]
    public CorrectiveTransaction4Choice_? CorrectionTransaction { get; init; }
    
    /// <summary>
    /// Reference to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_eX_Og22PEei3KuUgpx7Xcw")]
    [Description(@"Reference to fix the case under investigation as part of the resolution.")]
    [DataMember(Name="RsltnRltdInf")]
    [XmlElement(ElementName="RsltnRltdInf")]
    public ResolutionData1? ResolutionRelatedInformation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_OhW2PEei3KuUgpx7Xcw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ResolutionOfInvestigationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ResolutionOfInvestigationV09Document ToDocument()
    {
        return new ResolutionOfInvestigationV09Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("RsltnOfInvstgtn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Assgnmt", xmlNamespace );
        Assignment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ResolvedCase is Case5 ResolvedCaseValue)
        {
            writer.WriteStartElement(null, "RslvdCase", xmlNamespace );
            ResolvedCaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        Status.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CancellationDetails is UnderlyingTransaction22 CancellationDetailsValue)
        {
            writer.WriteStartElement(null, "CxlDtls", xmlNamespace );
            CancellationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ModificationDetails is PaymentTransaction107 ModificationDetailsValue)
        {
            writer.WriteStartElement(null, "ModDtls", xmlNamespace );
            ModificationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClaimNonReceiptDetails is ClaimNonReceipt2Choice_ ClaimNonReceiptDetailsValue)
        {
            writer.WriteStartElement(null, "ClmNonRctDtls", xmlNamespace );
            ClaimNonReceiptDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StatementDetails is StatementResolutionEntry4 StatementDetailsValue)
        {
            writer.WriteStartElement(null, "StmtDtls", xmlNamespace );
            StatementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorrectionTransaction is CorrectiveTransaction4Choice_ CorrectionTransactionValue)
        {
            writer.WriteStartElement(null, "CrrctnTx", xmlNamespace );
            CorrectionTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResolutionRelatedInformation is ResolutionData1 ResolutionRelatedInformationValue)
        {
            writer.WriteStartElement(null, "RsltnRltdInf", xmlNamespace );
            ResolutionRelatedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ResolutionOfInvestigationV09 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ResolutionOfInvestigationV09"/>.
/// </summary>
[Serializable]
public partial record ResolutionOfInvestigationV09Document : IOuterDocument<ResolutionOfInvestigationV09>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ResolutionOfInvestigationV09"/> is required.
    /// </summary>
    [DataMember(Name=ResolutionOfInvestigationV09.XmlTag)]
    public required ResolutionOfInvestigationV09 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(ResolutionOfInvestigationV09.XmlTag);
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
