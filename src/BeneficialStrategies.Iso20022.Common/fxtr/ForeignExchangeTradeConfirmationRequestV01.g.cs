﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeConfirmationRequestV01.  ISO2002 ID# _2qmO4ESCEeStEe_B2dcrqg.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope
///  The ForeignExchangeTradeConfirmationRequest message is sent from a market participant to a Central matching utility (CMU) to request a foreign exchange(spot/forward/swap) trade confirmation.
/// Usage
/// The confirmation request is sent by the market participants to the CMU after they receiving the capture reports.
/// Note that a confirmation request could be cancelled or amended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope| The ForeignExchangeTradeConfirmationRequest message is sent from a market participant to a Central matching utility (CMU) to request a foreign exchange(spot/forward/swap) trade confirmation.||Usage|The confirmation request is sent by the market participants to the CMU after they receiving the capture reports.|Note that a confirmation request could be cancelled or amended.")]
public partial record ForeignExchangeTradeConfirmationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Message management information.
    /// </summary>
    [IsoId("_7SxT4ESCEeStEe_B2dcrqg")]
    [Description(@"Message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Identifies the confirm request messge.
    /// </summary>
    [IsoId("_FSjWwESDEeStEe_B2dcrqg")]
    [Description(@"Identifies the confirm request messge.")]
    [DataMember(Name="ReqId")]
    [XmlElement(ElementName="ReqId")]
    [Required]
    public required SomeRequestIdentificationRecord RequestIdentification { get; init; }
    
    /// <summary>
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_IqUj0ESDEeStEe_B2dcrqg")]
    [Description(@"Details of the treasury trade confirmed.")]
    [DataMember(Name="TradDtl")]
    [XmlElement(ElementName="TradDtl")]
    [Required]
    public required SomeTradeDetailRecord TradeDetail { get; init; }
    
    /// <summary>
    /// Identifies the type of confirmation message being sent.
    /// </summary>
    [IsoId("_x4TUcIsWEeS_1fMypAW06w")]
    [Description(@"Identifies the type of confirmation message being sent.")]
    [DataMember(Name="ConfTp")]
    [XmlElement(ElementName="ConfTp")]
    [Required]
    public required SomeConfirmationTypeRecord ConfirmationType { get; init; }
    
    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_11BnEESpEeSTS-T7FO4CUQ")]
    [Description(@"Period of the inquiry.")]
    [DataMember(Name="QryPrd")]
    [XmlElement(ElementName="QryPrd")]
    [Required]
    public required SomeQueryPeriodRecord QueryPeriod { get; init; }
    
    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_WDuD4KaZEeSR8qifggAitQ")]
    [Description(@"Start number in request result.")]
    [DataMember(Name="QryStartNb")]
    [XmlElement(ElementName="QryStartNb")]
    [Required]
    public required SomeQueryStartNumberRecord QueryStartNumber { get; init; }
    
    /// <summary>
    /// Specifies the inquiry status of the trade.
    /// </summary>
    [IsoId("_15tBMKadEeSR8qifggAitQ")]
    [Description(@"Specifies the inquiry status of the trade.")]
    [DataMember(Name="QryTradSts")]
    [XmlElement(ElementName="QryTradSts")]
    [Required]
    public required SomeQueryTradeStatusRecord QueryTradeStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_upa4YKHlEeS69KkQis5bYg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeConfirmationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeConfirmationRequestV01Document ToDocument()
    {
        return new ForeignExchangeTradeConfirmationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeConfirmationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeConfirmationRequestV01Document : IOuterDocument<ForeignExchangeTradeConfirmationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.034.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeConfirmationRequestV01"/> is required.
    /// </summary>
    public required ForeignExchangeTradeConfirmationRequestV01 Message { get; init; }
}