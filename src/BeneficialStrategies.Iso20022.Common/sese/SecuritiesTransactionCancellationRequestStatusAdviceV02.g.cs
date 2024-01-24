﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTransactionCancellationRequestStatusAdviceV02.  ISO2002 ID# _ECTI8dtaEd-RF5yaMAVhAw.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// using the relevant elements in the Business Application Header.
/// Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends an SecuritiesTransactionCancellationRequestStatusAdvice to an account owner to advise the status of a securities transaction cancellation request previously sent by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.|using the relevant elements in the Business Application Header.|Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesTransactionCancellationRequestStatusAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxCxlReqStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_ECTI9dtaEd-RF5yaMAVhAw")]
    [Description(@"Reference to the unambiguous identification of the cancellation request as per the account owner.")]
    [DataMember(Name="CxlReqRef")]
    [XmlElement(ElementName="CxlReqRef")]
    [Required]
    public required SomeCancellationRequestReferenceRecord CancellationRequestReference { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_ECTI99taEd-RF5yaMAVhAw")]
    [Description(@"Unambiguous identification of the transaction as known by the account servicer.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public SomeTransactionIdentificationRecord? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_ECTI-dtaEd-RF5yaMAVhAw")]
    [Description(@"Provides details on the processing status of the request.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    [Required]
    public required SomeProcessingStatusRecord ProcessingStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_ECTI-9taEd-RF5yaMAVhAw")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public SomeTransactionDetailsRecord? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ECTJAdtaEd-RF5yaMAVhAw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTransactionCancellationRequestStatusAdviceV02Document ToDocument()
    {
        return new SecuritiesTransactionCancellationRequestStatusAdviceV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesTransactionCancellationRequestStatusAdviceV02Document : IOuterDocument<SecuritiesTransactionCancellationRequestStatusAdviceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.027.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTransactionCancellationRequestStatusAdviceV02"/> is required.
    /// </summary>
    public required SecuritiesTransactionCancellationRequestStatusAdviceV02 Message { get; init; }
}
