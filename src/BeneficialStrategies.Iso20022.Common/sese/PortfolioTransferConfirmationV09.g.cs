﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferConfirmationV09.  ISO2002 ID# _9xnhsUyFEeir2sRRVd9XhA.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// The PortfolioTransferConfirmation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party for example, a (new) plan manager (transferee), to confirm the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee). 
/// Usage
/// The PortfolioTransferConfirmation message is used to confirm one or more portfolio transfers for one client.
/// The reference of each portfolio transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original portfolio transfer as assigned by the instructing party is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the portfolio transfers were conveyed may also be quoted in RelatedReference but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The PortfolioTransferConfirmation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party for example, a (new) plan manager (transferee), to confirm the transfer of financial instruments from the client’s account at the old plan manager (transferor) to the clients account at the new plan manager (transferee). |Usage|The PortfolioTransferConfirmation message is used to confirm one or more portfolio transfers for one client.|The reference of each portfolio transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original portfolio transfer as assigned by the instructing party is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the portfolio transfers were conveyed may also be quoted in RelatedReference but this is not recommended.")]
public partial record PortfolioTransferConfirmationV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_9xnhv0yFEeir2sRRVd9XhA")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required MessageIdentification1 MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_9xnhwUyFEeir2sRRVd9XhA")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_9xnhw0yFEeir2sRRVd9XhA")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9xnhxUyFEeir2sRRVd9XhA")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhx0yFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the primary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Official registered holder information. 
    /// </summary>
    [IsoId("_ohJB0FLUEeiSDqv62fL07g")]
    [Description(@"Official registered holder information. ")]
    [DataMember(Name="RegdHldr")]
    [XmlElement(ElementName="RegdHldr")]
    public IndividualPerson8? RegisteredHolder { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhyUyFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_9xnhy0yFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the other individual investors, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_9xnhzUyFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the primary corporate investor, for example, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public Organisation36? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_9xnhz0yFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the secondary corporate investor, for example, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public Organisation36? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_9xnh0UyFEeir2sRRVd9XhA")]
    [Description(@"Information identifying the other corporate investors, for example, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public Organisation36? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_9xnh00yFEeir2sRRVd9XhA")]
    [Description(@"Identification of the account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required InvestmentAccount69 TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_9xnh1UyFEeir2sRRVd9XhA")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public InvestmentAccount69? NomineeAccount { get; init; }
    
    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_9xnh10yFEeir2sRRVd9XhA")]
    [Description(@"Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required PartyIdentification132 Transferee { get; init; }
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_9xnh2UyFEeir2sRRVd9XhA")]
    [Description(@"Identification of a related party or intermediary.")]
    [DataMember(Name="IntrmyInf")]
    [XmlElement(ElementName="IntrmyInf")]
    public Intermediary43? IntermediaryInformation { get; init; }
    
    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_9xnh3UyFEeir2sRRVd9XhA")]
    [Description(@"Information about the portfolio and assets.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required PortfolioTransfer4 ProductTransfer { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9xnh30yFEeir2sRRVd9XhA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9xnh4UyFEeir2sRRVd9XhA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferConfirmationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferConfirmationV09Document ToDocument()
    {
        return new PortfolioTransferConfirmationV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferConfirmationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PortfolioTransferConfirmationV09Document : IOuterDocument<PortfolioTransferConfirmationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferConfirmationV09"/> is required.
    /// </summary>
    public required PortfolioTransferConfirmationV09 Message { get; init; }
}
