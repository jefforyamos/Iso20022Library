﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionReportV03.  ISO2002 ID# _2UxmeNE8Ed-BzquC8wXy7w_-1389761233.
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
/// This record is an implementation of the tsmt.041.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransactionReport message is sent by the matching application to the requester of a transaction report.
/// This message is used to report on various details of transactions registered in the matching application.
/// Usage
/// The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TransactionReport message is sent by the matching application to the requester of a transaction report.|This message is used to report on various details of transactions registered in the matching application.|Usage|The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.")]
public partial record TransactionReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.041.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxRpt";
    
    #nullable enable
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_2UxmedE8Ed-BzquC8wXy7w_-1389761119")]
    [Description(@"Identifies the report.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required MessageIdentification1 ReportIdentification { get; init; }
    
    /// <summary>
    /// Reference to the previous message requesting the report.
    /// </summary>
    [IsoId("_2U6wYNE8Ed-BzquC8wXy7w_-1389760800")]
    [Description(@"Reference to the previous message requesting the report.")]
    [DataMember(Name="RltdMsgRef")]
    [XmlElement(ElementName="RltdMsgRef")]
    [Required]
    public required MessageIdentification1 RelatedMessageReference { get; init; }
    
    /// <summary>
    /// Detailed description of the items that correspond to the parameters set in the request.
    /// </summary>
    [IsoId("_2U6wYdE8Ed-BzquC8wXy7w_-1389761189")]
    [Description(@"Detailed description of the items that correspond to the parameters set in the request.")]
    [DataMember(Name="RptdItms")]
    [XmlElement(ElementName="RptdItms")]
    public TransactionReportItems3? ReportedItems { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionReportV03Document ToDocument()
    {
        return new TransactionReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransactionReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionReportV03Document : IOuterDocument<TransactionReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionReportV03"/> is required.
    /// </summary>
    public required TransactionReportV03 Message { get; init; }
}
