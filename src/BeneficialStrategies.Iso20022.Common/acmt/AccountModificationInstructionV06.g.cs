﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountModificationInstructionV06.  ISO2002 ID# _BYmMsR8LEeWpZde3LQh6dg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.003.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to modify, that is, create, update or delete specific details of an existing account.
/// Usage
/// The AccountModificationInstruction message is used to modify the details of an existing account.
/// The AccountModificationInstruction message has three specific uses:
/// - to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,
/// - to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,
/// - to delete specific account details, for example, delete cash standing instructions.
/// This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.
/// The usage of this message may be subject to service level agreement (SLA) between the counterparties.
/// Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to modify, that is, create, update or delete specific details of an existing account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message has three specific uses:|- to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,|- to delete specific account details, for example, delete cash standing instructions.|This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountModificationInstructionV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_BYmMwR8LEeWpZde3LQh6dg")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_BYmMwx8LEeWpZde3LQh6dg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }
    
    /// <summary>
    /// Information about the modification instruction.
    /// </summary>
    [IsoId("_BYmMxR8LEeWpZde3LQh6dg")]
    [Description(@"Information about the modification instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    public InvestmentAccountModification2? InstructionDetails { get; init; }
    
    /// <summary>
    /// Identifies the account for which the information is modified.
    /// </summary>
    [IsoId("_BYmMxx8LEeWpZde3LQh6dg")]
    [Description(@"Identifies the account for which the information is modified.")]
    [DataMember(Name="InvstmtAcctSelctn")]
    [XmlElement(ElementName="InvstmtAcctSelctn")]
    [Required]
    public required IAccountSelection1Choice InvestmentAccountSelection { get; init; }
    
    /// <summary>
    /// Information related to general characteristics of the account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmMyR8LEeWpZde3LQh6dg")]
    [Description(@"Information related to general characteristics of the account to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdInvstmtAcct")]
    [XmlElement(ElementName="ModfdInvstmtAcct")]
    public InvestmentAccount51? ModifiedInvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to an account party to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmMyx8LEeWpZde3LQh6dg")]
    [Description(@"Information related to an account party to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdAcctPties")]
    [XmlElement(ElementName="ModfdAcctPties")]
    public required IReadOnlyCollection<AccountParties14> ModifiedAccountParties { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmMzR8LEeWpZde3LQh6dg")]
    [Description(@"Information related to intermediaries to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIntrmies")]
    [XmlElement(ElementName="ModfdIntrmies")]
    public required IReadOnlyCollection<ModificationScope26> ModifiedIntermediaries { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to referral information to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmMzx8LEeWpZde3LQh6dg")]
    [Description(@"Information related to referral information to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdPlcmnt")]
    [XmlElement(ElementName="ModfdPlcmnt")]
    public ModificationScope33? ModifiedPlacement { get; init; }
    
    /// <summary>
    /// Eligibility conditions related to allocation of new issues to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmM0R8LEeWpZde3LQh6dg")]
    [Description(@"Eligibility conditions related to allocation of new issues to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIsseAllcn")]
    [XmlElement(ElementName="ModfdIsseAllcn")]
    public ModificationScope21? ModifiedIssueAllocation { get; init; }
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmM0x8LEeWpZde3LQh6dg")]
    [Description(@"Information related to a savings plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    [XmlElement(ElementName="ModfdSvgsInvstmtPlan")]
    public required IReadOnlyCollection<ModificationScope28> ModifiedSavingsInvestmentPlan { get; init; } = []; // Min=0, Max=50
    
    /// <summary>
    /// Information related to a withdrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_BYmM1R8LEeWpZde3LQh6dg")]
    [Description(@"Information related to a withdrawal plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    [XmlElement(ElementName="ModfdWdrwlInvstmtPlan")]
    public required IReadOnlyCollection<ModificationScope28> ModifiedWithdrawalInvestmentPlan { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction to be either inserted or deleted.
    /// </summary>
    [IsoId("_BYmM1x8LEeWpZde3LQh6dg")]
    [Description(@"Cash settlement standing instruction to be either inserted or deleted.")]
    [DataMember(Name="ModfdCshSttlm")]
    [XmlElement(ElementName="ModfdCshSttlm")]
    public required IReadOnlyCollection<CashSettlement2> ModifiedCashSettlement { get; init; } = []; // Min=0, Max=8
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("_BYmM2R8LEeWpZde3LQh6dg")]
    [Description(@"Information related to documents to be added, deleted or updated.|.")]
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    [XmlElement(ElementName="ModfdSvcLvlAgrmt")]
    public required IReadOnlyCollection<ModificationScope31> ModifiedServiceLevelAgreement { get; init; } = []; // Min=0, Max=30
    
    /// <summary>
    /// Additional information concerning limitations and restrictions on the account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_kcEtoCFoEeW9XJWqfgXIIA")]
    [Description(@"Additional information concerning limitations and restrictions on the account to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdAddtlInf")]
    [XmlElement(ElementName="ModfdAddtlInf")]
    public ModificationScope30? ModifiedAdditionalInformation { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_BYmM2x8LEeWpZde3LQh6dg")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_BYmM3R8LEeWpZde3LQh6dg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountModificationInstructionV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountModificationInstructionV06Document ToDocument()
    {
        return new AccountModificationInstructionV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountModificationInstructionV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountModificationInstructionV06Document : IOuterDocument<AccountModificationInstructionV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountModificationInstructionV06"/> is required.
    /// </summary>
    public required AccountModificationInstructionV06 Message { get; init; }
}
