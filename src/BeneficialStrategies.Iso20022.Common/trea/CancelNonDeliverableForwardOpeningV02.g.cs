﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelNonDeliverableForwardOpeningV02.  ISO2002 ID# _L_cYkNE8Ed-BzquC8wXy7w_-895168583.
//
namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// Scope
/// The CancelNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the cancellation of the opening of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CancelNonDeliverableForwardOpening message is sent by a participant to a central system or to a counterparty to notify the cancellation of the opening of a non deliverable trade previously confirmed by the sender.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.")]
public partial record CancelNonDeliverableForwardOpeningV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclNDFOpngV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides references and date of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYkdE8Ed-BzquC8wXy7w_1664087842")]
    [Description(@"Provides references and date of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required SomeTradeInformationRecord TradeInformation { get; init; }
    
    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYktE8Ed-BzquC8wXy7w_940702862")]
    [Description(@"Specifies the trading side of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    public SomeTradingSideIdentificationRecord? TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYk9E8Ed-BzquC8wXy7w_513113458")]
    [Description(@"Specifies the counterparty of the non deliverable trade which is cancelled.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    public SomeCounterpartySideIdentificationRecord? CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYlNE8Ed-BzquC8wXy7w_1602210594")]
    [Description(@"Specifies the amounts of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    public SomeTradeAmountsRecord? TradeAmounts { get; init; }
    
    /// <summary>
    /// Specifies the rate of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYldE8Ed-BzquC8wXy7w_1140450467")]
    [Description(@"Specifies the rate of the non deliverable trade which is cancelled.")]
    [DataMember(Name="AgrdRate")]
    [XmlElement(ElementName="AgrdRate")]
    public SomeAgreedRateRecord? AgreedRate { get; init; }
    
    /// <summary>
    /// Specifies the valuation conditions of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_L_cYltE8Ed-BzquC8wXy7w_-1799937844")]
    [Description(@"Specifies the valuation conditions of the non deliverable trade which is cancelled.")]
    [DataMember(Name="ValtnConds")]
    [XmlElement(ElementName="ValtnConds")]
    public SomeValuationConditionsRecord? ValuationConditions { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelNonDeliverableForwardOpeningV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelNonDeliverableForwardOpeningV02Document ToDocument()
    {
        return new CancelNonDeliverableForwardOpeningV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CancelNonDeliverableForwardOpeningV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CancelNonDeliverableForwardOpeningV02Document : IOuterDocument<CancelNonDeliverableForwardOpeningV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelNonDeliverableForwardOpeningV02"/> is required.
    /// </summary>
    public required CancelNonDeliverableForwardOpeningV02 Message { get; init; }
}