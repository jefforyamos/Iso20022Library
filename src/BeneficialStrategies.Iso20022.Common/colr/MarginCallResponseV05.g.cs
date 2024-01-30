﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarginCallResponseV05.  ISO2002 ID# _J4YkLygrEeyB747fKu7_rw.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// When sent by the collateral giver the MarginCallResponse message is used to:
/// - fully accept the MarginCallRequest
/// - or partially accept the MarginCallRequest.
/// When sent by the collateral taker the MarginCallResponse message is used to:
/// - fully accept the recall of collateral
/// - or partially accept the recall of collateral.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral giver the MarginCallResponse message is used to:|- fully accept the MarginCallRequest|- or partially accept the MarginCallRequest.||When sent by the collateral taker the MarginCallResponse message is used to:|- fully accept the recall of collateral|- or partially accept the recall of collateral.")]
public partial record MarginCallResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkNSgrEeyB747fKu7_rw")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkNygrEeyB747fKu7_rw")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation9 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YkOSgrEeyB747fKu7_rw")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement4? Agreement { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_J4YkOygrEeyB747fKu7_rw")]
    [Description(@"Provides details about the margin calculation that would be due to party A.")]
    [DataMember(Name="MrgnDtlsDueToA")]
    [XmlElement(ElementName="MrgnDtlsDueToA")]
    public MarginCall1? MarginDetailsDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_J4YkPSgrEeyB747fKu7_rw")]
    [Description(@"Provides details about the margin calculation that would be due to party B.")]
    [DataMember(Name="MrgnDtlsDueToB")]
    [XmlElement(ElementName="MrgnDtlsDueToB")]
    public MarginCall1? MarginDetailsDueToB { get; init; }
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party A.
    /// </summary>
    [IsoId("_J4YkPygrEeyB747fKu7_rw")]
    [Description(@"Provides details about the agreed amount that would be due to party A.")]
    [DataMember(Name="AgrdAmtDueToA")]
    [XmlElement(ElementName="AgrdAmtDueToA")]
    public IAgreedAmount1Choice? AgreedAmountDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party B.
    /// </summary>
    [IsoId("_J4YkQSgrEeyB747fKu7_rw")]
    [Description(@"Provides details about the agreed amount that would be due to party B.")]
    [DataMember(Name="AgrdAmtDueToB")]
    [XmlElement(ElementName="AgrdAmtDueToB")]
    public IAgreedAmount1Choice? AgreedAmountDueToB { get; init; }
    
    /// <summary>
    /// Provides response details about the margin call.
    /// </summary>
    [IsoId("_J4YkQygrEeyB747fKu7_rw")]
    [Description(@"Provides response details about the margin call.")]
    [DataMember(Name="RspnDtls")]
    [XmlElement(ElementName="RspnDtls")]
    public Response1? ResponseDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkRSgrEeyB747fKu7_rw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarginCallResponseV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarginCallResponseV05Document ToDocument()
    {
        return new MarginCallResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarginCallResponseV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MarginCallResponseV05Document : IOuterDocument<MarginCallResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.004.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarginCallResponseV05"/> is required.
    /// </summary>
    public required MarginCallResponseV05 Message { get; init; }
}
