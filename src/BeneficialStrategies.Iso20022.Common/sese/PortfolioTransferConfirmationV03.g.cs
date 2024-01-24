﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferConfirmationV03.  ISO2002 ID# _InkSUfpcEeCPwaG9zjUPNQ.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An executing party, eg, a (old) plan manager (Transferor), sends the PortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager (Transferee), to confirm the transfer of one or more ISA or portfolio products from the client's account at the old plan manager (Transferor) to the client's account at the new plan manager (Transferee) through a nominee account.
/// Usage
/// The PortfolioTransferConfirmation message is used to confirm the transfer of one or more ISA or portfolio products.
/// The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, eg, a (old) plan manager (Transferor), sends the PortfolioTransferConfirmation message to the instructing party, eg, a (new) plan manager (Transferee), to confirm the transfer of one or more ISA or portfolio products from the client's account at the old plan manager (Transferor) to the client's account at the new plan manager (Transferee) through a nominee account.|Usage|The PortfolioTransferConfirmation message is used to confirm the transfer of one or more ISA or portfolio products.|The reference of each product transfer confirmation is identified in TransferConfirmationIdentification. The reference of the original product transfer is specified in TransferInstructionReference. The message identification of the PortfolioTransferInstruction message in which the product transfers were conveyed may also be quoted in RelatedReference.")]
public partial record PortfolioTransferConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_InkSbfpcEeCPwaG9zjUPNQ")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required SomeMessageReferenceRecord MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_InkScfpcEeCPwaG9zjUPNQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_InkSdfpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_InkSefpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_InkSffpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the primary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public SomePrimaryIndividualInvestorRecord? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_InkSgfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public SomeSecondaryIndividualInvestorRecord? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_InkShfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the other individual investors, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public SomeOtherIndividualInvestorRecord? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_InkSifpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the primary corporate investor, eg, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public SomePrimaryCorporateInvestorRecord? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_InkSjfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the secondary corporate investor, eg, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public SomeSecondaryCorporateInvestorRecord? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_InkSkfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the other corporate investors, eg, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public SomeOtherCorporateInvestorRecord? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_InkSlfpcEeCPwaG9zjUPNQ")]
    [Description(@"Identification of an account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required SomeTransferorAccountRecord TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_InkSmfpcEeCPwaG9zjUPNQ")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public SomeNomineeAccountRecord? NomineeAccount { get; init; }
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_InkSnfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information related to the institution to which the financial instrument is to be transferred.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required SomeTransfereeRecord Transferee { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_InkSofpcEeCPwaG9zjUPNQ")]
    [Description(@"Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    public SomeCashAccountRecord? CashAccount { get; init; }
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_InkSpfpcEeCPwaG9zjUPNQ")]
    [Description(@"Provides information related to the asset(s) transferred.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required SomeProductTransferRecord ProductTransfer { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_InkSqfpcEeCPwaG9zjUPNQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferConfirmationV03Document ToDocument()
    {
        return new PortfolioTransferConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferConfirmationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PortfolioTransferConfirmationV03Document : IOuterDocument<PortfolioTransferConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferConfirmationV03"/> is required.
    /// </summary>
    public required PortfolioTransferConfirmationV03 Message { get; init; }
}
