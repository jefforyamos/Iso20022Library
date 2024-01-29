﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustodyStatementOfHoldingsCancellation.  ISO2002 ID# _MXYVe9FSEd-BzquC8wXy7w_1108713826.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent (sub-custodian) acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message is used to cancel a previously sent CustodyStatementOfHoldings message.
/// Usage
/// The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner to cancel a previously sent CustodyStatementOfHoldings message.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent (sub-custodian) acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message is used to cancel a previously sent CustodyStatementOfHoldings message.|Usage|The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner to cancel a previously sent CustodyStatementOfHoldings message.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record CustodyStatementOfHoldingsCancellation : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.004.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MXYVfNFSEd-BzquC8wXy7w_1620345511")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required SomePreviousReferenceRecord PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MXYVfdFSEd-BzquC8wXy7w_1938037635")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_MXYVftFSEd-BzquC8wXy7w_1983699054")]
    [Description(@"Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required SomeMessagePaginationRecord MessagePagination { get; init; }
    
    /// <summary>
    /// The Custody Statement of Holdings message to cancel.
    /// </summary>
    [IsoId("_MXhfYNFSEd-BzquC8wXy7w_-1021887814")]
    [Description(@"The Custody Statement of Holdings message to cancel.")]
    [DataMember(Name="StmtToBeCanc")]
    [XmlElement(ElementName="StmtToBeCanc")]
    public SomeStatementToBeCancelledRecord? StatementToBeCancelled { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustodyStatementOfHoldingsCancellationDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustodyStatementOfHoldingsCancellationDocument ToDocument()
    {
        return new CustodyStatementOfHoldingsCancellationDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustodyStatementOfHoldingsCancellation"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustodyStatementOfHoldingsCancellationDocument : IOuterDocument<CustodyStatementOfHoldingsCancellation>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustodyStatementOfHoldingsCancellation"/> is required.
    /// </summary>
    public required CustodyStatementOfHoldingsCancellation Message { get; init; }
}