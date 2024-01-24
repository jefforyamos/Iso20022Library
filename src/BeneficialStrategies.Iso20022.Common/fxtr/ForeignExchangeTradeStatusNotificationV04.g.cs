﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeStatusNotificationV04.  ISO2002 ID# _t2x7Iew0EeG4a9QeNHA19w.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope|
/// The ForeignExchangeTradeStatusNotification message is sent by a central system to the participant to notify the current status of a foreign exchange trade in the system.|
/// Usage|
/// This ForeignExchangeTradeStatusNotification message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The ForeignExchangeTradeStatusNotification message is sent by a central system to the participant to notify the current status of a foreign exchange trade in the system.||Usage||This ForeignExchangeTradeStatusNotification message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.")]
public partial record ForeignExchangeTradeStatusNotificationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradStsNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides information on the status of a trade in a system.
    /// </summary>
    [IsoId("_t2x7I-w0EeG4a9QeNHA19w")]
    [Description(@"Provides information on the status of a trade in a system.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required SomeTradeDataRecord TradeData { get; init; }
    
    /// <summary>
    /// This is information that is to be provided to trade repositories in the context of the regulatory standards around OTC derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_xavYcCjtEeK1Sbo8NpBROA")]
    [Description(@"This is information that is to be provided to trade repositories in the context of the regulatory standards around OTC derivatives, central counterparties and trade repositories.")]
    [DataMember(Name="RgltryRptg")]
    [XmlElement(ElementName="RgltryRptg")]
    public SomeRegulatoryReportingRecord? RegulatoryReporting { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_OCmy4ynBEeKqmMA7_Y42sg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeStatusNotificationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeStatusNotificationV04Document ToDocument()
    {
        return new ForeignExchangeTradeStatusNotificationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeStatusNotificationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeStatusNotificationV04Document : IOuterDocument<ForeignExchangeTradeStatusNotificationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeStatusNotificationV04"/> is required.
    /// </summary>
    public required ForeignExchangeTradeStatusNotificationV04 Message { get; init; }
}
