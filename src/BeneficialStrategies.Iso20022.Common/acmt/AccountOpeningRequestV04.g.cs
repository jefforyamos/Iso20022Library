﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningRequestV04.  ISO2002 ID# _1ENlzdcAEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.")]
public partial record AccountOpeningRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_1ENl09cAEeq_l4BJLVUF2Q")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_1ENl1dcAEeq_l4BJLVUF2Q")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification29? From { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_1ENl19cAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="Acct")]
    [XmlElement(ElementName="Acct")]
    [Required]
    public required CustomerAccount4 Account { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_1ENl2dcAEeq_l4BJLVUF2Q")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract2? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_1ENl29cAEeq_l4BJLVUF2Q")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_1ENl3dcAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_1ENl39cAEeq_l4BJLVUF2Q")]
    [Description(@"Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.")]
    [DataMember(Name="Org")]
    [XmlElement(ElementName="Org")]
    [Required]
    public required Organisation33 Organisation { get; init; }
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_1ENl4dcAEeq_l4BJLVUF2Q")]
    [Description(@"Information specifying the account mandate.")]
    [DataMember(Name="Mndt")]
    [XmlElement(ElementName="Mndt")]
    public OperationMandate4? Mandate { get; init; }
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_1ENl49cAEeq_l4BJLVUF2Q")]
    [Description(@"Definition of a group of parties.")]
    [DataMember(Name="Grp")]
    [XmlElement(ElementName="Grp")]
    public Group4? Group { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_1ENl5dcAEeq_l4BJLVUF2Q")]
    [Description(@"Unique and unambiguous identification of the account used as a reference for the opening of another account.")]
    [DataMember(Name="RefAcct")]
    [XmlElement(ElementName="RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_1ENl59cAEeq_l4BJLVUF2Q")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1ENl6dcAEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningRequestV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningRequestV04Document ToDocument()
    {
        return new AccountOpeningRequestV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningRequestV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountOpeningRequestV04Document : IOuterDocument<AccountOpeningRequestV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.007.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningRequestV04"/> is required.
    /// </summary>
    public required AccountOpeningRequestV04 Message { get; init; }
}
