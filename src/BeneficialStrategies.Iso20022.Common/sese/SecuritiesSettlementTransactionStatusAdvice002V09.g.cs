﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionStatusAdvice002V09.  ISO2002 ID# _vE6o0832Eee5nJBZsW8MFQ.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An account servicer sends a SecuritiesSettlementTransactionStatusAdvice to an account owner to advise the status of a securities settlement transaction instruction previously sent by the account owner or the status of a settlement transaction existing in the books of the servicer for the account of the owner. The status may be a processing, pending processing, internal matching, matching and/or settlement status.
/// The status advice may be sent as a response to the request of the account owner or not.
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
[Description(@"Scope|An account servicer sends a SecuritiesSettlementTransactionStatusAdvice to an account owner to advise the status of a securities settlement transaction instruction previously sent by the account owner or the status of a settlement transaction existing in the books of the servicer for the account of the owner. The status may be a processing, pending processing, internal matching, matching and/or settlement status.|The status advice may be sent as a response to the request of the account owner or not.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionStatusAdvice002V09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_vE6o4c32Eee5nJBZsW8MFQ")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required TransactionIdentifications38 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Link to another transaction - provided for information only.
    /// </summary>
    [IsoId("_vE6o4832Eee5nJBZsW8MFQ")]
    [Description(@"Link to another transaction - provided for information only.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public Linkages50? Linkages { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_vE6o5c32Eee5nJBZsW8MFQ")]
    [Description(@"Provides details on the processing status of the transaction.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    public IProcessingStatus63Choice? ProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_vE6o5832Eee5nJBZsW8MFQ")]
    [Description(@"Provides the matching status of an instruction as per the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).")]
    [DataMember(Name="IfrrdMtchgSts")]
    [XmlElement(ElementName="IfrrdMtchgSts")]
    public IMatchingStatus32Choice? InferredMatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_vE6o6c32Eee5nJBZsW8MFQ")]
    [Description(@"Provides the matching status of the instruction.")]
    [DataMember(Name="MtchgSts")]
    [XmlElement(ElementName="MtchgSts")]
    public IMatchingStatus32Choice? MatchingStatus { get; init; }
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_vE6o6832Eee5nJBZsW8MFQ")]
    [Description(@"Provides the status of settlement of a transaction.")]
    [DataMember(Name="SttlmSts")]
    [XmlElement(ElementName="SttlmSts")]
    public ISettlementStatus22Choice? SettlementStatus { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_vE6o7c32Eee5nJBZsW8MFQ")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public TransactionDetails110? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vE6o7832Eee5nJBZsW8MFQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionStatusAdvice002V09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionStatusAdvice002V09Document ToDocument()
    {
        return new SecuritiesSettlementTransactionStatusAdvice002V09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionStatusAdvice002V09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionStatusAdvice002V09Document : IOuterDocument<SecuritiesSettlementTransactionStatusAdvice002V09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.024.002.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionStatusAdvice002V09"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionStatusAdvice002V09 Message { get; init; }
}
