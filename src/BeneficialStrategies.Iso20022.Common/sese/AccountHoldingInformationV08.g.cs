﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountHoldingInformationV08.  ISO2002 ID# _tnnVsZDhEem7fvtoGpNpow.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information on the individual assets held in a client's account. The assets may be part of a tax efficient product, a pension of general investment product.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountHoldingInformation message is sent by an executing party, for example, a (old) plan manager (transferor), to the instructing party, for example, a (new) plan manager (transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information on the individual assets held in a client's account. The assets may be part of a tax efficient product, a pension of general investment product.")]
public partial record AccountHoldingInformationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_tnnVuZDhEem7fvtoGpNpow")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required SomeMessageReferenceRecord MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_tnnVu5DhEem7fvtoGpNpow")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_tnnVvZDhEem7fvtoGpNpow")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_tnnVv5DhEem7fvtoGpNpow")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Business flow direction (assets to be delivered or received).
    /// </summary>
    [IsoId("_tnnVwZDhEem7fvtoGpNpow")]
    [Description(@"Business flow direction (assets to be delivered or received).")]
    [DataMember(Name="BizFlowDrctnTp")]
    [XmlElement(ElementName="BizFlowDrctnTp")]
    public SomeBusinessFlowDirectionTypeRecord? BusinessFlowDirectionType { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_tnnVw5DhEem7fvtoGpNpow")]
    [Description(@"Information identifying the primary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public SomePrimaryIndividualInvestorRecord? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_tnnVxZDhEem7fvtoGpNpow")]
    [Description(@"Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public SomeSecondaryIndividualInvestorRecord? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_tnnVx5DhEem7fvtoGpNpow")]
    [Description(@"Information identifying the other individual investors, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public SomeOtherIndividualInvestorRecord? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_tnnVyZDhEem7fvtoGpNpow")]
    [Description(@"Information identifying the primary corporate investor, for example, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public SomePrimaryCorporateInvestorRecord? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_tnnVy5DhEem7fvtoGpNpow")]
    [Description(@"Information identifying the secondary corporate investor, for example, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public SomeSecondaryCorporateInvestorRecord? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_tnnVzZDhEem7fvtoGpNpow")]
    [Description(@"Information identifying the other corporate investors, for example, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public SomeOtherCorporateInvestorRecord? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_tnnVz5DhEem7fvtoGpNpow")]
    [Description(@"Identification of the account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required SomeTransferorAccountRecord TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_tnnV0ZDhEem7fvtoGpNpow")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public SomeNomineeAccountRecord? NomineeAccount { get; init; }
    
    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_tnnV05DhEem7fvtoGpNpow")]
    [Description(@"Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required SomeTransfereeRecord Transferee { get; init; }
    
    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_tnnV1ZDhEem7fvtoGpNpow")]
    [Description(@"Information about the portfolio and assets.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required SomeProductTransferRecord ProductTransfer { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_tnnV15DhEem7fvtoGpNpow")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public SomeMarketPracticeVersionRecord? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_tnnV2ZDhEem7fvtoGpNpow")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountHoldingInformationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountHoldingInformationV08Document ToDocument()
    {
        return new AccountHoldingInformationV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountHoldingInformationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountHoldingInformationV08Document : IOuterDocument<AccountHoldingInformationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountHoldingInformationV08"/> is required.
    /// </summary>
    public required AccountHoldingInformationV08 Message { get; init; }
}