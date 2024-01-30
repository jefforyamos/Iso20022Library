﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeBulkStatusNotificationV05.  ISO2002 ID# _mJe8YQM-Ee2nqoJcXIhTdw.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope|
/// The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.")]
public partial record ForeignExchangeTradeBulkStatusNotificationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradBlkStsNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information on the status of the trade in the central system.
    /// </summary>
    [IsoId("_mJe8ZQM-Ee2nqoJcXIhTdw")]
    [Description(@"Information on the status of the trade in the central system.|")]
    [DataMember(Name="StsDtls")]
    [XmlElement(ElementName="StsDtls")]
    [Required]
    public required TradeData12 StatusDetails { get; init; }
    
    /// <summary>
    /// Identifies one or more trades for which the status notification is sent.
    /// </summary>
    [IsoId("_mJe8ZwM-Ee2nqoJcXIhTdw")]
    [Description(@"Identifies one or more trades for which the status notification is sent.|")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeData40 TradeData { get; init; }
    
    /// <summary>
    /// Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_mJe8aQM-Ee2nqoJcXIhTdw")]
    [Description(@"Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJe8awM-Ee2nqoJcXIhTdw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeBulkStatusNotificationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeBulkStatusNotificationV05Document ToDocument()
    {
        return new ForeignExchangeTradeBulkStatusNotificationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeBulkStatusNotificationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeBulkStatusNotificationV05Document : IOuterDocument<ForeignExchangeTradeBulkStatusNotificationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.030.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeBulkStatusNotificationV05"/> is required.
    /// </summary>
    public required ForeignExchangeTradeBulkStatusNotificationV05 Message { get; init; }
}
