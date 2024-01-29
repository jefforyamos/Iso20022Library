﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportV02.  ISO2002 ID# _ZtUJstEvEd-BzquC8wXy7w_-1004257172.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// Scope
/// The PriceReport message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.
/// This message is used to provide net asset value and price information for financial instruments on given trade dates and, optionally, to quote price variation information.
/// Usage
/// The PriceReport message can be used to:
/// - report prices for one or several different financial instruments for one or several different trade dates,
/// - report statistical information about the valuation of a financial instrument,
/// - inform another party that the quotation of a financial instrument is suspended,
/// - report prices that are used for other purposes than the execution of investment funds orders.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The PriceReport message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.|This message is used to provide net asset value and price information for financial instruments on given trade dates and, optionally, to quote price variation information.|Usage|The PriceReport message can be used to:|- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for other purposes than the execution of investment funds orders.")]
public partial record PriceReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "reda.001.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_ZtUJs9EvEd-BzquC8wXy7w_1513384046")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_ZtUJtNEvEd-BzquC8wXy7w_1511536226")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_ZtUJtdEvEd-BzquC8wXy7w_1502301030")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_ZtUJttEvEd-BzquC8wXy7w_-158313846")]
    [Description(@"Information related to the price valuation of a financial instrument.")]
    [DataMember(Name="PricValtnDtls")]
    [XmlElement(ElementName="PricValtnDtls")]
    [Required]
    public required SomePriceValuationDetailsRecord PriceValuationDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZtUJt9EvEd-BzquC8wXy7w_1630736372")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportV02Document ToDocument()
    {
        return new PriceReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportV02Document : IOuterDocument<PriceReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportV02"/> is required.
    /// </summary>
    public required PriceReportV02 Message { get; init; }
}