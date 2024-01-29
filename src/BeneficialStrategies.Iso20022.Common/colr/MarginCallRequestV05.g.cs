﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MarginCallRequestV05.  ISO2002 ID# _J4YkESgrEeyB747fKu7_rw.
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
public partial record MarginCallRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkFygrEeyB747fKu7_rw")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkGSgrEeyB747fKu7_rw")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required SomeObligationRecord Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YkGygrEeyB747fKu7_rw")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public SomeAgreementRecord? Agreement { get; init; }
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_J4YkHSgrEeyB747fKu7_rw")]
    [Description(@"Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.")]
    [DataMember(Name="MrgnCallRslt")]
    [XmlElement(ElementName="MrgnCallRslt")]
    [Required]
    public required SomeMarginCallResultRecord MarginCallResult { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_J4YkHygrEeyB747fKu7_rw")]
    [Description(@"Provides details about the margin calculation that would be due to party A.")]
    [DataMember(Name="MrgnDtlsDueToA")]
    [XmlElement(ElementName="MrgnDtlsDueToA")]
    public SomeMarginDetailsDueToARecord? MarginDetailsDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_J4YkISgrEeyB747fKu7_rw")]
    [Description(@"Provides details about the margin calculation that would be due to party B.")]
    [DataMember(Name="MrgnDtlsDueToB")]
    [XmlElement(ElementName="MrgnDtlsDueToB")]
    public SomeMarginDetailsDueToBRecord? MarginDetailsDueToB { get; init; }
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_J4YkIygrEeyB747fKu7_rw")]
    [Description(@"Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.")]
    [DataMember(Name="RqrmntDtlsDueToA")]
    [XmlElement(ElementName="RqrmntDtlsDueToA")]
    public SomeRequirementDetailsDueToARecord? RequirementDetailsDueToA { get; init; }
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_J4YkJSgrEeyB747fKu7_rw")]
    [Description(@"Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.")]
    [DataMember(Name="RqrmntDtlsDueToB")]
    [XmlElement(ElementName="RqrmntDtlsDueToB")]
    public SomeRequirementDetailsDueToBRecord? RequirementDetailsDueToB { get; init; }
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_J4YkJygrEeyB747fKu7_rw")]
    [Description(@"Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.")]
    [DataMember(Name="XpctdCollDueToA")]
    [XmlElement(ElementName="XpctdCollDueToA")]
    public SomeExpectedCollateralDueToARecord? ExpectedCollateralDueToA { get; init; }
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_J4YkKSgrEeyB747fKu7_rw")]
    [Description(@"Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.")]
    [DataMember(Name="XpctdCollDueToB")]
    [XmlElement(ElementName="XpctdCollDueToB")]
    public SomeExpectedCollateralDueToBRecord? ExpectedCollateralDueToB { get; init; }
    
    /// <summary>
    /// Allows the reporting of the margin requirements for multiple accounts and report a single margin call amount made up of the aggregate of all the individual requirement amounts.
    /// </summary>
    [IsoId("_J4YkKygrEeyB747fKu7_rw")]
    [Description(@"Allows the reporting of the margin requirements for multiple accounts and report a single margin call amount made up of the aggregate of all the individual requirement amounts.")]
    [DataMember(Name="MrgnCallDtls")]
    [XmlElement(ElementName="MrgnCallDtls")]
    public SomeMarginCallDetailsRecord? MarginCallDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkLSgrEeyB747fKu7_rw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MarginCallRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MarginCallRequestV05Document ToDocument()
    {
        return new MarginCallRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MarginCallRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MarginCallRequestV05Document : IOuterDocument<MarginCallRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MarginCallRequestV05"/> is required.
    /// </summary>
    public required MarginCallRequestV05 Message { get; init; }
}