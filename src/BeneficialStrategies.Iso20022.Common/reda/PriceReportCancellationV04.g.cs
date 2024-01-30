﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportCancellationV04.  ISO2002 ID# _M87dQRj3EeKxeog5DTmtgg.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// SCOPE
/// A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.|
/// USAGE
/// The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE|A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.||USAGE|The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. ||")]
public partial record PriceReportCancellationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCxl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_M87dQxj3EeKxeog5DTmtgg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_M87dRxj3EeKxeog5DTmtgg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_M87dSxj3EeKxeog5DTmtgg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_M87dTxj3EeKxeog5DTmtgg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_NPnKdRmAEeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the price report, as assigned by the reporting party.")]
    [DataMember(Name="PricRptId")]
    [XmlElement(ElementName="PricRptId")]
    [Required]
    public required IsoMax35Text PriceReportIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_epzJZRmAEeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.")]
    [DataMember(Name="CxlId")]
    [XmlElement(ElementName="CxlId")]
    [Required]
    public required IsoMax35Text CancellationIdentification { get; init; }
    
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_06rKcBmAEeKxsrht2duUcg")]
    [Description(@"Reason for the cancellation.")]
    [DataMember(Name="CxlRsn")]
    [XmlElement(ElementName="CxlRsn")]
    public IsoMax350Text? CancellationReason { get; init; }
    
    /// <summary>
    /// Date or date and time the price will be corrected.
    /// </summary>
    [IsoId("_RTTz8BmBEeKxsrht2duUcg")]
    [Description(@"Date or date and time the price will be corrected.")]
    [DataMember(Name="XpctdPricCrrctnDt")]
    [XmlElement(ElementName="XpctdPricCrrctnDt")]
    public IDateAndDateTime1Choice? ExpectedPriceCorrectionDate { get; init; }
    
    /// <summary>
    /// Indicates whether or not all the prices of the referenced price report are cancelled.
    /// </summary>
    [IsoId("_Cj3HgBmCEeKxsrht2duUcg")]
    [Description(@"Indicates whether or not all the prices of the referenced price report are cancelled.")]
    [DataMember(Name="CmpltPricCxl")]
    [XmlElement(ElementName="CmpltPricCxl")]
    [Required]
    public required IsoYesNoIndicator CompletePriceCancellation { get; init; }
    
    /// <summary>
    /// Details of prices to be cancelled.
    /// </summary>
    [IsoId("_M87dUxj3EeKxeog5DTmtgg")]
    [Description(@"Details of prices to be cancelled.")]
    [DataMember(Name="CancPricValtnDtls")]
    [XmlElement(ElementName="CancPricValtnDtls")]
    public PriceReport3? CancelledPriceValuationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2sI2JRmCEeKxsrht2duUcg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportCancellationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportCancellationV04Document ToDocument()
    {
        return new PriceReportCancellationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportCancellationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportCancellationV04Document : IOuterDocument<PriceReportCancellationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportCancellationV04"/> is required.
    /// </summary>
    public required PriceReportCancellationV04 Message { get; init; }
}
