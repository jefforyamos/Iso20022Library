﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionReportV02.  ISO2002 ID# _0kYl0cKvEeuzU9S_IANlog.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionReport message is sent by the report submitting entity to the trade repository (TR) to report on the securities financing transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.")]
public partial record SecuritiesFinancingReportingTransactionReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [IsoId("_0kYl08KvEeuzU9S_IANlog")]
    [Description(@"Set of data concerning the reporting trade.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required SomeTradeDataRecord TradeData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_0kYl1cKvEeuzU9S_IANlog")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionReportV02Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionReportV02Document : IOuterDocument<SecuritiesFinancingReportingTransactionReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.052.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionReportV02"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionReportV02 Message { get; init; }
}
