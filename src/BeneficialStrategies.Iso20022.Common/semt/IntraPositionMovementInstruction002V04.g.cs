﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraPositionMovementInstruction002V04.  ISO2002 ID# _5PaGo5NLEeWGlc8L7oPDIg.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account owner sends a IntraPositionMovementInstruction to an account servicer to instruct the movement of securities within its holding from one sub-balance to another, for example, blocking of securities.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with its local agent (sub-custodian), or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information.
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends a IntraPositionMovementInstruction to an account servicer to instruct the movement of securities within its holding from one sub-balance to another, for example, blocking of securities.|The account owner/servicer relationship may be:|- a global custodian which has an account with its local agent (sub-custodian), or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure.|Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information.|using the relevant elements in the Business Application Header.")]
public partial record IntraPositionMovementInstruction002V04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntInstr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_5PaGpZNLEeWGlc8L7oPDIg")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_5PaGp5NLEeWGlc8L7oPDIg")]
    [Description(@"Identification assigned by the account servicer to unambiguously identify a corporate action event.")]
    [DataMember(Name="CorpActnEvtId")]
    [XmlElement(ElementName="CorpActnEvtId")]
    public SomeCorporateActionEventIdentificationRecord? CorporateActionEventIdentification { get; init; }
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_5PaGqZNLEeWGlc8L7oPDIg")]
    [Description(@"Count of the number of transactions linked.")]
    [DataMember(Name="NbCounts")]
    [XmlElement(ElementName="NbCounts")]
    public SomeNumberCountsRecord? NumberCounts { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_5PaGq5NLEeWGlc8L7oPDIg")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Lnkgs")]
    [XmlElement(ElementName="Lnkgs")]
    public SomeLinkagesRecord? Linkages { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_5PaGrZNLEeWGlc8L7oPDIg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public SomeAccountOwnerRecord? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_5PaGr5NLEeWGlc8L7oPDIg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SomeSafekeepingAccountRecord SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_5PaGsZNLEeWGlc8L7oPDIg")]
    [Description(@"Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).")]
    [DataMember(Name="SfkpgPlc")]
    [XmlElement(ElementName="SfkpgPlc")]
    public SomeSafekeepingPlaceRecord? SafekeepingPlace { get; init; }
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_5PaGs5NLEeWGlc8L7oPDIg")]
    [Description(@"Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.")]
    [DataMember(Name="FinInstrmId")]
    [XmlElement(ElementName="FinInstrmId")]
    [Required]
    public required SomeFinancialInstrumentIdentificationRecord FinancialInstrumentIdentification { get; init; }
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_5PaGtZNLEeWGlc8L7oPDIg")]
    [Description(@"Elements characterising a financial instrument.")]
    [DataMember(Name="FinInstrmAttrbts")]
    [XmlElement(ElementName="FinInstrmAttrbts")]
    public SomeFinancialInstrumentAttributesRecord? FinancialInstrumentAttributes { get; init; }
    
    /// <summary>
    /// Intra-position movement transaction details.
    /// </summary>
    [IsoId("_5PaGt5NLEeWGlc8L7oPDIg")]
    [Description(@"Intra-position movement transaction details.")]
    [DataMember(Name="IntraPosDtls")]
    [XmlElement(ElementName="IntraPosDtls")]
    [Required]
    public required SomeIntraPositionDetailsRecord IntraPositionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5PaGuZNLEeWGlc8L7oPDIg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraPositionMovementInstruction002V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraPositionMovementInstruction002V04Document ToDocument()
    {
        return new IntraPositionMovementInstruction002V04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraPositionMovementInstruction002V04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraPositionMovementInstruction002V04Document : IOuterDocument<IntraPositionMovementInstruction002V04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.013.002.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraPositionMovementInstruction002V04"/> is required.
    /// </summary>
    public required IntraPositionMovementInstruction002V04 Message { get; init; }
}
