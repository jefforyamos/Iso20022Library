﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningInstructionV08.  ISO2002 ID# _jDZTkZDiEem7fvtoGpNpow.
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
/// This record is an implementation of the acmt.001.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountOpeningInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian or securities depository, to instruct the opening of an account or the opening of an account and the establishment of an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountOpeningInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian or securities depository, to instruct the opening of an account or the opening of an account and the establishment of an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountOpeningInstructionV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstr";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_jDZTl5DiEem7fvtoGpNpow")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_jDZTmZDiEem7fvtoGpNpow")]
    [Description(@"Identifies a related order or settlement transaction.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_jDZTm5DiEem7fvtoGpNpow")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference13? PreviousReference { get; init; }
    
    /// <summary>
    /// Information about the opening instruction.
    /// </summary>
    [IsoId("_jDZTnZDiEem7fvtoGpNpow")]
    [Description(@"Information about the opening instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    [Required]
    public required InvestmentAccountOpening4 InstructionDetails { get; init; }
    
    /// <summary>
    /// Detailed information about the account to be opened.
    /// </summary>
    [IsoId("_jDZTn5DiEem7fvtoGpNpow")]
    [Description(@"Detailed information about the account to be opened.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    [Required]
    public required InvestmentAccount73 InvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_jDZToZDiEem7fvtoGpNpow")]
    [Description(@"Information related to parties that are related to the account, for example, primary account owner.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    [Required]
    public required AccountParties17 AccountParties { get; init; }
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_jDZTo5DiEem7fvtoGpNpow")]
    [Description(@"Intermediary or other party related to the management of the account.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public Intermediary46? Intermediaries { get; init; }
    
    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_jDZTpZDiEem7fvtoGpNpow")]
    [Description(@"Referral information.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public ReferredAgent3? Placement { get; init; }
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_jDZTp5DiEem7fvtoGpNpow")]
    [Description(@"Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_jDZTqZDiEem7fvtoGpNpow")]
    [Description(@"Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required IReadOnlyCollection<InvestmentPlan17> SavingsInvestmentPlan { get; init; } = []; // Min=0, Max=50
    
    /// <summary>
    /// Plan through which holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_jDZTq5DiEem7fvtoGpNpow")]
    [Description(@"Plan through which holdings are depleted through regular withdrawals at specified intervals.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required IReadOnlyCollection<InvestmentPlan17> WithdrawalInvestmentPlan { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_jDZTrZDiEem7fvtoGpNpow")]
    [Description(@"Cash settlement standing instruction associated to transactions on the account.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public required IReadOnlyCollection<CashSettlement3> CashSettlement { get; init; } = []; // Min=0, Max=8
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_jDZTr5DiEem7fvtoGpNpow")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required IReadOnlyCollection<DocumentToSend4> ServiceLevelAgreement { get; init; } = []; // Min=0, Max=30
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the account management activity and or any limitations and restrictions.
    /// </summary>
    [IsoId("_jDZTsZDiEem7fvtoGpNpow")]
    [Description(@"Additional information such as remarks or notes that must be conveyed about the account management activity and or any limitations and restrictions.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public AdditiononalInformation13? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_jDZTs5DiEem7fvtoGpNpow")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jDZTtZDiEem7fvtoGpNpow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningInstructionV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningInstructionV08Document ToDocument()
    {
        return new AccountOpeningInstructionV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningInstructionV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountOpeningInstructionV08Document : IOuterDocument<AccountOpeningInstructionV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningInstructionV08"/> is required.
    /// </summary>
    public required AccountOpeningInstructionV08 Message { get; init; }
}
