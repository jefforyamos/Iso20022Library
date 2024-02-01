﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferInstructionV05.  ISO2002 ID# _g-OfsRXfEeOocOqSQt5Jbw.
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
/// This record is an implementation of the sese.012.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a (new) plan manager (Transferee), sends the PortfolioTransferInstruction message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the clients account at the old plan manager (Transferor) to the clients account at the new plan manager (Transferee) through a nominee account.
/// Usage
/// The PortfolioTransferInstruction message is used to instruct the withdrawal of one or more ISA or portfolio products from one account and deliver them to another account.
/// The PortfolioTransferInstruction message is used to instruct one or more transfers for one client. Each transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors. Each transfer is identified in TransferIdentification.
/// If the instructing party does not have enough information to instruct the transfer, then it must first send a AccountHoldingInformationRequest message to the executing party in order to receive a AccountHoldingInformation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, a (new) plan manager (Transferee), sends the PortfolioTransferInstruction message to the executing party, for example, a (old) plan manager (Transferor), on behalf of the initiating party, for example, an investor (client), to instruct the transfer of financial instruments from the clients account at the old plan manager (Transferor) to the clients account at the new plan manager (Transferee) through a nominee account.|Usage|The PortfolioTransferInstruction message is used to instruct the withdrawal of one or more ISA or portfolio products from one account and deliver them to another account.|The PortfolioTransferInstruction message is used to instruct one or more transfers for one client. Each transfer is for delivery to the same account. The account may be owned by one or more individual investors or one or more corporate investors. Each transfer is identified in TransferIdentification.|If the instructing party does not have enough information to instruct the transfer, then it must first send a AccountHoldingInformationRequest message to the executing party in order to receive a AccountHoldingInformation message.")]
public partial record PortfolioTransferInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.012.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfInstr";
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_g-OfuxXfEeOocOqSQt5Jbw")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required MessageIdentification1 MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_g-OfvRXfEeOocOqSQt5Jbw")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_g-OfvxXfEeOocOqSQt5Jbw")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_g-OfwRXfEeOocOqSQt5Jbw")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_g-OfwxXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the primary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_g-OfxRXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_g-OfxxXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the other individual investors, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_g-OfyRXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the primary corporate investor, eg, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_g-OfyxXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the secondary corporate investor, eg, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_g-OfzRXfEeOocOqSQt5Jbw")]
    [Description(@"Information identifying the other corporate investors, eg, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_g-OfzxXfEeOocOqSQt5Jbw")]
    [Description(@"Identification of an account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required Account15 TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_g-Of0RXfEeOocOqSQt5Jbw")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public Account16? NomineeAccount { get; init; }
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_g-Of0xXfEeOocOqSQt5Jbw")]
    [Description(@"Information related to the institution to which the financial instrument is to be transferred.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required PartyIdentification2Choice_ Transferee { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    [IsoId("_g-Of1RXfEeOocOqSQt5Jbw")]
    [Description(@"Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    public CashAccount29? CashAccount { get; init; }
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_g-Of1xXfEeOocOqSQt5Jbw")]
    [Description(@"Provides information related to the asset(s) transferred.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required ISATransfer16 ProductTransfer { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_rdMrwRw8EeOIveEnnb_1-A")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_g-Of2RXfEeOocOqSQt5Jbw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferInstructionV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferInstructionV05Document ToDocument()
    {
        return new PortfolioTransferInstructionV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferInstructionV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PortfolioTransferInstructionV05Document : IOuterDocument<PortfolioTransferInstructionV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.012.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferInstructionV05"/> is required.
    /// </summary>
    public required PortfolioTransferInstructionV05 Message { get; init; }
}
