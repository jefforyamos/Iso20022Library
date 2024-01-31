﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ActivityReportV04.  ISO2002 ID# _fPCaYefGEeKNfc-Rw_dPYg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// Scope
/// The ActivityReport message is sent by the matching application to the requester of an activity report.
/// This message is used to report on all transactions for which an activity has taken place within a given time span.
/// Usage
/// The ActivityReport message can be sent
/// - at a pre-determined time every 24 hours. The message reports on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.
/// - on demand in response to an ActivityReportRequest message. The message reports on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester in the ActivityReportRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ActivityReport message is sent by the matching application to the requester of an activity report.|This message is used to report on all transactions for which an activity has taken place within a given time span.|Usage|The ActivityReport message can be sent|- at a pre-determined time every 24 hours. The message reports on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.|- on demand in response to an ActivityReportRequest message. The message reports on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester in the ActivityReportRequest message.")]
public partial record ActivityReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActvtyRpt";
    
    #nullable enable
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_fPCaZefGEeKNfc-Rw_dPYg")]
    [Description(@"Identifies the report.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required MessageIdentification1 ReportIdentification { get; init; }
    
    /// <summary>
    /// Reference to the previous message requesting the report.
    /// </summary>
    [IsoId("_fPCaZ-fGEeKNfc-Rw_dPYg")]
    [Description(@"Reference to the previous message requesting the report.")]
    [DataMember(Name="RltdMsgRef")]
    [XmlElement(ElementName="RltdMsgRef")]
    public MessageIdentification1? RelatedMessageReference { get; init; }
    
    /// <summary>
    /// Describes the events that occurred for one transaction.
    /// </summary>
    [IsoId("_fPCaaefGEeKNfc-Rw_dPYg")]
    [Description(@"Describes the events that occurred for one transaction.")]
    [DataMember(Name="Rpt")]
    [XmlElement(ElementName="Rpt")]
    public ActivityReportItems3? Report { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ActivityReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ActivityReportV04Document ToDocument()
    {
        return new ActivityReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ActivityReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ActivityReportV04Document : IOuterDocument<ActivityReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ActivityReportV04"/> is required.
    /// </summary>
    public required ActivityReportV04 Message { get; init; }
}
