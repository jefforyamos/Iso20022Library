﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ErrorReportV03.  ISO2002 ID# _oHDjhdE8Ed-BzquC8wXy7w_-1687018808.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The ErrorReport message is sent by the matching application to the party from which it received a message.
/// This message is used to inform about the inability of the matching application to process a received message.
/// Usage
/// The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because
/// - the syntax of the message is incorrect,or
/// - the message content is inconsistent,or
/// - according to the workflow implemented in the matching application, it did not expect the received message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ErrorReport message is sent by the matching application to the party from which it received a message.|This message is used to inform about the inability of the matching application to process a received message.|Usage|The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because|- the syntax of the message is incorrect,or|- the message content is inconsistent,or|- according to the workflow implemented in the matching application, it did not expect the received message.")]
public partial record ErrorReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ErrRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_oHDjhtE8Ed-BzquC8wXy7w_-1686098714")]
    [Description(@"Identifies the report.")]
    [DataMember(Name="RptId")]
    [XmlElement(ElementName="RptId")]
    [Required]
    public required SomeReportIdentificationRecord ReportIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_oHDjh9E8Ed-BzquC8wXy7w_-1686098652")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public SomeTransactionIdentificationRecord? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_oHDjiNE8Ed-BzquC8wXy7w_-1686098591")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    public SomeEstablishedBaselineIdentificationRecord? EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_oHDjidE8Ed-BzquC8wXy7w_-1686098560")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="TxSts")]
    [XmlElement(ElementName="TxSts")]
    public SomeTransactionStatusRecord? TransactionStatus { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the financial institution which is the sender of the rejected message.
    /// </summary>
    [IsoId("_oHDjitE8Ed-BzquC8wXy7w_-1686098745")]
    [Description(@"Reference to the transaction for the financial institution which is the sender of the rejected message.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public SomeUserTransactionReferenceRecord? UserTransactionReference { get; init; }
    
    /// <summary>
    /// Reference to the identification of the rejected message.
    /// </summary>
    [IsoId("_oHDji9E8Ed-BzquC8wXy7w_-1686098683")]
    [Description(@"Reference to the identification of the rejected message.")]
    [DataMember(Name="RjctdMsgRef")]
    [XmlElement(ElementName="RjctdMsgRef")]
    public SomeRejectedMessageReferenceRecord? RejectedMessageReference { get; init; }
    
    /// <summary>
    /// Specifies the total number of errors identified in the rejected message.
    /// </summary>
    [IsoId("_oHNUgNE8Ed-BzquC8wXy7w_-1687018798")]
    [Description(@"Specifies the total number of errors identified in the rejected message.")]
    [DataMember(Name="NbOfErrs")]
    [XmlElement(ElementName="NbOfErrs")]
    [Required]
    public required SomeNumberOfErrorsRecord NumberOfErrors { get; init; }
    
    /// <summary>
    /// Describes the error that is the cause of the rejection.
    /// </summary>
    [IsoId("_oHNUgdE8Ed-BzquC8wXy7w_-1686098797")]
    [Description(@"Describes the error that is the cause of the rejection.")]
    [DataMember(Name="ErrDesc")]
    [XmlElement(ElementName="ErrDesc")]
    [Required]
    public required SomeErrorDescriptionRecord ErrorDescription { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_oHNUgtE8Ed-BzquC8wXy7w_-1686098530")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public SomeRequestForActionRecord? RequestForAction { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ErrorReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ErrorReportV03Document ToDocument()
    {
        return new ErrorReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ErrorReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ErrorReportV03Document : IOuterDocument<ErrorReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.016.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ErrorReportV03"/> is required.
    /// </summary>
    public required ErrorReportV03 Message { get; init; }
}