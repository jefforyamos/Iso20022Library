﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTransactionCancellationRequestStatusAdviceV07.  ISO2002 ID# _78fdgSgVEeym1_Zp1BTvEw.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesTransactionCancellationRequestStatusAdviceV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxCxlReqStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_78fdkSgVEeym1_Zp1BTvEw")]
    [Description(@"Reference to the unambiguous identification of the cancellation request as per the account owner.")]
    [DataMember(Name="CxlReqRef")]
    [XmlElement(ElementName="CxlReqRef")]
    [Required]
    public required IsoMax35Text CancellationRequestReference { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_78fdkygVEeym1_Zp1BTvEw")]
    [Description(@"Unambiguous identification of the transaction as known by the account servicer.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public TransactionIdentifications48? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_78fdlSgVEeym1_Zp1BTvEw")]
    [Description(@"Provides details on the processing status of the request.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required IProcessingStatus84Choice ProcessingStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_78fdlygVEeym1_Zp1BTvEw")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public TransactionDetails152? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_78fdmSgVEeym1_Zp1BTvEw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTransactionCancellationRequestStatusAdviceV07Document ToDocument()
    {
        return new SecuritiesTransactionCancellationRequestStatusAdviceV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTransactionCancellationRequestStatusAdviceV07Document : IOuterDocument<SecuritiesTransactionCancellationRequestStatusAdviceV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.027.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV07"/> is required.
    /// </summary>
    public required SecuritiesTransactionCancellationRequestStatusAdviceV07 Message { get; init; }
}
