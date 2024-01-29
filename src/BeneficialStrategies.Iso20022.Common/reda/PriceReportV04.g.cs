﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportV04.  ISO2002 ID# _IOkQsRj3EeKxeog5DTmtgg.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// SCOPE||A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.||USAGE||The PriceReport message is sent by the report provider to the report recipient to: |- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for other purposes than the execution of investment funds orders.|.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"SCOPE||A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.||USAGE||The PriceReport message is sent by the report provider to the report recipient to: |- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for other purposes than the execution of investment funds orders.|.")]
public partial record PriceReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_IOkQtxj3EeKxeog5DTmtgg")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_IOkQuxj3EeKxeog5DTmtgg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_IOkQvxj3EeKxeog5DTmtgg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_IOkQwxj3EeKxeog5DTmtgg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_IOkQxxj3EeKxeog5DTmtgg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required SomeMessagePaginationRecord MessagePagination { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("__CwxkBl8EeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the price report, as assigned by the reporting party.")]
    [DataMember(Name="PricRptId")]
    [XmlElement(ElementName="PricRptId")]
    [Required]
    public required SomePriceReportIdentificationRecord PriceReportIdentification { get; init; }
    
    /// <summary>
    /// Function of the price report, that is, whether the price report is a new price report or a replacement of some kind.
    /// </summary>
    [IsoId("_TO56wBl9EeKxsrht2duUcg")]
    [Description(@"Function of the price report, that is, whether the price report is a new price report or a replacement of some kind.")]
    [DataMember(Name="Fctn")]
    [XmlElement(ElementName="Fctn")]
    [Required]
    public required SomeFunctionRecord Function { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_CDo2sBl_EeKxsrht2duUcg")]
    [Description(@"Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.")]
    [DataMember(Name="CxlId")]
    [XmlElement(ElementName="CxlId")]
    public SomeCancellationIdentificationRecord? CancellationIdentification { get; init; }
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_IOkQyxj3EeKxeog5DTmtgg")]
    [Description(@"Information related to the price valuation of a financial instrument.")]
    [DataMember(Name="PricValtnDtls")]
    [XmlElement(ElementName="PricValtnDtls")]
    [Required]
    public required SomePriceValuationDetailsRecord PriceValuationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IOkQzxj3EeKxeog5DTmtgg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportV04Document ToDocument()
    {
        return new PriceReportV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportV04Document : IOuterDocument<PriceReportV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportV04"/> is required.
    /// </summary>
    public required PriceReportV04 Message { get; init; }
}