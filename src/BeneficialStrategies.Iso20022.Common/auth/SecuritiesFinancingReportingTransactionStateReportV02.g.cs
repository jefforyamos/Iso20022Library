﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionStateReportV02.  ISO2002 ID# _9g7DAcKvEeuzU9S_IANlog.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingTransactionStateReport is sent by the trade repository (TR) to the other trade repository (TR) or the authority or made available to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionStateReport is sent by the trade repository (TR) to the other trade repository (TR) or the authority or made available to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the transaction.")]
public partial record SecuritiesFinancingReportingTransactionStateReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxStatRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_9g7DA8KvEeuzU9S_IANlog")]
    [Description(@"Information related to trade state reporting.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required SomeTradeDataRecord TradeData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9g7DBcKvEeuzU9S_IANlog")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionStateReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionStateReportV02Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionStateReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionStateReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionStateReportV02Document : IOuterDocument<SecuritiesFinancingReportingTransactionStateReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.079.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionStateReportV02"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionStateReportV02 Message { get; init; }
}
