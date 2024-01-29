﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionStatusAdviceV01.  ISO2002 ID# _2zvMLwuAEeqVvtu9Ny8FDA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingTransactionStatusAdvice message is sent by the trade repository (TR) to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, identifying the transactions rejected and the reasons for a rejection.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionStatusAdvice message is sent by the trade repository (TR) to the authority or made available to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, identifying the transactions rejected and the reasons for a rejection.")]
public partial record SecuritiesFinancingReportingTransactionStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides the status and reason of the transaction report advice.
    /// </summary>
    [IsoId("_2zvMMQuAEeqVvtu9Ny8FDA")]
    [Description(@"Provides the status and reason of the transaction report advice.")]
    [DataMember(Name="TxRptStsAndRsn")]
    [XmlElement(ElementName="TxRptStsAndRsn")]
    [Required]
    public required SomeTransactionReportStatusAndReasonRecord TransactionReportStatusAndReason { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2zvMMwuAEeqVvtu9Ny8FDA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionStatusAdviceV01Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionStatusAdviceV01Document : IOuterDocument<SecuritiesFinancingReportingTransactionStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.084.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionStatusAdviceV01"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionStatusAdviceV01 Message { get; init; }
}