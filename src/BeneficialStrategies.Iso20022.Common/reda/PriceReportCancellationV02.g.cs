﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PriceReportCancellationV02.  ISO2002 ID# _Zski2NEvEd-BzquC8wXy7w_-1589707882.
//
namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// Scope
/// The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.
/// The message is used to cancel a previously sent PriceReport message.
/// Usage
/// The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The PriceReportCancellation message is sent by a report provider, eg, a fund accountant, transfer agent, market data provider, or any other interested party, to a report user, eg, a fund management company, a transfer agent, market data provider, regulator or any other interested party.|The message is used to cancel a previously sent PriceReport message.|Usage|The PriceReportCancellation message is used to cancel an entire PriceReport message that was previously sent by the report provider. If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record PriceReportCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "reda.002.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Zski2dEvEd-BzquC8wXy7w_-1891280241")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zski2tEvEd-BzquC8wXy7w_-1948539540")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required SomePreviousReferenceRecord PreviousReference { get; init; }
    
    /// <summary>
    /// Common information related to all the price reports to be cancelled.
    /// </summary>
    [IsoId("_Zski29EvEd-BzquC8wXy7w_-1321950502")]
    [Description(@"Common information related to all the price reports to be cancelled.")]
    [DataMember(Name="PricRptToBeCanc")]
    [XmlElement(ElementName="PricRptToBeCanc")]
    public SomePriceReportToBeCancelledRecord? PriceReportToBeCancelled { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PriceReportCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PriceReportCancellationV02Document ToDocument()
    {
        return new PriceReportCancellationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PriceReportCancellationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PriceReportCancellationV02Document : IOuterDocument<PriceReportCancellationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PriceReportCancellationV02"/> is required.
    /// </summary>
    public required PriceReportCancellationV02 Message { get; init; }
}