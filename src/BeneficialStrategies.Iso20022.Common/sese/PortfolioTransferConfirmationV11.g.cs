﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferConfirmationV11.  ISO2002 ID# _U3whoekzEeu9cf4XM82AQQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.013.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
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
public partial record PortfolioTransferConfirmationV11 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.013.001.11";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfConf";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_U3whs-kzEeu9cf4XM82AQQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required MessageIdentification1 MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_U3whtekzEeu9cf4XM82AQQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_U3wht-kzEeu9cf4XM82AQQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_U3whuekzEeu9cf4XM82AQQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_U3whu-kzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the primary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Official registered holder information. 
    /// </summary>
    [IsoId("_U3whvekzEeu9cf4XM82AQQ")]
    [Description(@"Official registered holder information. ")]
    [DataMember(Name="RegdHldr")]
    [XmlElement(ElementName="RegdHldr")]
    public IndividualPerson8? RegisteredHolder { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_U3whv-kzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the secondary individual investor, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, for example, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_U3whwekzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the other individual investors, for example, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_U3whw-kzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the primary corporate investor, for example, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public Organisation36? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, for example, name and address.
    /// </summary>
    [IsoId("_U3whxekzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the secondary corporate investor, for example, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public Organisation36? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, for example, name and address.
    /// </summary>
    [IsoId("_U3whx-kzEeu9cf4XM82AQQ")]
    [Description(@"Information identifying the other corporate investors, for example, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public Organisation36? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of the account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_U3whyekzEeu9cf4XM82AQQ")]
    [Description(@"Identification of the account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required InvestmentAccount69 TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_U3why-kzEeu9cf4XM82AQQ")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public InvestmentAccount69? NomineeAccount { get; init; }
    
    /// <summary>
    /// Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.
    /// </summary>
    [IsoId("_U3whzekzEeu9cf4XM82AQQ")]
    [Description(@"Identification of the institution to which the financial instrument is to be transferred. This may also be known as the new plan manager.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required PartyIdentification132 Transferee { get; init; }
    
    /// <summary>
    /// Information about the portfolio and assets.
    /// </summary>
    [IsoId("_U3whz-kzEeu9cf4XM82AQQ")]
    [Description(@"Information about the portfolio and assets.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required PortfolioTransfer10 ProductTransfer { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_U3wh0ekzEeu9cf4XM82AQQ")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U3wh0-kzEeu9cf4XM82AQQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferConfirmationV11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferConfirmationV11Document ToDocument()
    {
        return new PortfolioTransferConfirmationV11Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferConfirmationV11"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PortfolioTransferConfirmationV11Document : IOuterDocument<PortfolioTransferConfirmationV11>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.013.001.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferConfirmationV11"/> is required.
    /// </summary>
    public required PortfolioTransferConfirmationV11 Message { get; init; }
}
