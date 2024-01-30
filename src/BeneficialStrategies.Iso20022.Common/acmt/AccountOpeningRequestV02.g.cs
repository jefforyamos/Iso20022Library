﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningRequestV02.  ISO2002 ID# _dIOvUQ1TEeKGXqvMN6jpiw.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.")]
public partial record AccountOpeningRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_dIOvUw1TEeKGXqvMN6jpiw")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required References4 References { get; init; }
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_iDVlIA1YEeKGXqvMN6jpiw")]
    [Description(@"Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.")]
    [DataMember(Name="Fr")]
    [XmlElement(ElementName="Fr")]
    public OrganisationIdentification8? From { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_dIOvVw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="Acct")]
    [XmlElement(ElementName="Acct")]
    [Required]
    public required CustomerAccount4 Account { get; init; }
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_dIOvWw1TEeKGXqvMN6jpiw")]
    [Description(@"Specifies target dates.")]
    [DataMember(Name="CtrctDts")]
    [XmlElement(ElementName="CtrctDts")]
    public AccountContract2? ContractDates { get; init; }
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_dIOvXw1TEeKGXqvMN6jpiw")]
    [Description(@"Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.")]
    [DataMember(Name="UndrlygMstrAgrmt")]
    [XmlElement(ElementName="UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_dIOvYw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_dIOvZw1TEeKGXqvMN6jpiw")]
    [Description(@"Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.")]
    [DataMember(Name="Org")]
    [XmlElement(ElementName="Org")]
    [Required]
    public required Organisation12 Organisation { get; init; }
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_dIOvaw1TEeKGXqvMN6jpiw")]
    [Description(@"Information specifying the account mandate.")]
    [DataMember(Name="Mndt")]
    [XmlElement(ElementName="Mndt")]
    public OperationMandate2? Mandate { get; init; }
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_HCr0cA4XEeKGXqvMN6jpiw")]
    [Description(@"Definition of a group of parties.")]
    [DataMember(Name="Grp")]
    [XmlElement(ElementName="Grp")]
    public Group1? Group { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_dIOvbw1TEeKGXqvMN6jpiw")]
    [Description(@"Unique and unambiguous identification of the account used as a reference for the opening of another account.")]
    [DataMember(Name="RefAcct")]
    [XmlElement(ElementName="RefAcct")]
    public CashAccount24? ReferenceAccount { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_dIOvcw1TEeKGXqvMN6jpiw")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qpMt0A3_EeKGXqvMN6jpiw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningRequestV02Document ToDocument()
    {
        return new AccountOpeningRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountOpeningRequestV02Document : IOuterDocument<AccountOpeningRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.007.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningRequestV02"/> is required.
    /// </summary>
    public required AccountOpeningRequestV02 Message { get; init; }
}
