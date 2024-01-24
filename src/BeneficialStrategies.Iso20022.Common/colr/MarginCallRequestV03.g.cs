﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarginCallRequestV03.  ISO2002 ID# _EIYSoVnMEeSPgY23yCMQSQ.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager
/// This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager's request.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// When sent by the collateral taker the MarginCallRequest message is used to:
/// - request new collateral at the initiation of an exposure
/// - request additional collateral
/// When sent by the collateral giver the MarginCallRequest message is used to:
/// - request the return of collateral.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager|This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager's request.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral taker the MarginCallRequest message is used to:|- request new collateral at the initiation of an exposure|- request additional collateral|When sent by the collateral giver the MarginCallRequest message is used to:|- request the return of collateral.")]
public partial record MarginCallRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_EIYSo1nMEeSPgY23yCMQSQ")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_EIYSpVnMEeSPgY23yCMQSQ")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required SomeObligationRecord Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_EIYSp1nMEeSPgY23yCMQSQ")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public SomeAgreementRecord? Agreement { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_EIYSqVnMEeSPgY23yCMQSQ")]
    [Description(@"Provides details about the margin calculation that would be due to party A.")]
    [DataMember(Name="MrgnDtlsDueToA")]
    [XmlElement(ElementName="MrgnDtlsDueToA")]
    public SomeMarginDetailsDueToARecord? MarginDetailsDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_EIYSq1nMEeSPgY23yCMQSQ")]
    [Description(@"Provides details about the margin calculation that would be due to party B.")]
    [DataMember(Name="MrgnDtlsDueToB")]
    [XmlElement(ElementName="MrgnDtlsDueToB")]
    public SomeMarginDetailsDueToBRecord? MarginDetailsDueToB { get; init; }
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_EIYSrVnMEeSPgY23yCMQSQ")]
    [Description(@"Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.")]
    [DataMember(Name="RqrmntDtlsDueToA")]
    [XmlElement(ElementName="RqrmntDtlsDueToA")]
    public SomeRequirementDetailsDueToARecord? RequirementDetailsDueToA { get; init; }
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_EIYSr1nMEeSPgY23yCMQSQ")]
    [Description(@"Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.")]
    [DataMember(Name="RqrmntDtlsDueToB")]
    [XmlElement(ElementName="RqrmntDtlsDueToB")]
    public SomeRequirementDetailsDueToBRecord? RequirementDetailsDueToB { get; init; }
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_EIYSsVnMEeSPgY23yCMQSQ")]
    [Description(@"Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.")]
    [DataMember(Name="MrgnCallRslt")]
    [XmlElement(ElementName="MrgnCallRslt")]
    [Required]
    public required SomeMarginCallResultRecord MarginCallResult { get; init; }
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_EIYSs1nMEeSPgY23yCMQSQ")]
    [Description(@"Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.")]
    [DataMember(Name="XpctdCollDueToB")]
    [XmlElement(ElementName="XpctdCollDueToB")]
    public SomeExpectedCollateralDueToBRecord? ExpectedCollateralDueToB { get; init; }
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_EIYStVnMEeSPgY23yCMQSQ")]
    [Description(@"Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.")]
    [DataMember(Name="XpctdCollDueToA")]
    [XmlElement(ElementName="XpctdCollDueToA")]
    public SomeExpectedCollateralDueToARecord? ExpectedCollateralDueToA { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_EIYSt1nMEeSPgY23yCMQSQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarginCallRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarginCallRequestV03Document ToDocument()
    {
        return new MarginCallRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarginCallRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MarginCallRequestV03Document : IOuterDocument<MarginCallRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarginCallRequestV03"/> is required.
    /// </summary>
    public required MarginCallRequestV03 Message { get; init; }
}
