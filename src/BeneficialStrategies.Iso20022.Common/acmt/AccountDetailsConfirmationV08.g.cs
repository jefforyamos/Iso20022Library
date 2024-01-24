﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountDetailsConfirmationV08.  ISO2002 ID# _lUvrIZDiEem7fvtoGpNpow.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:
/// - contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or
/// - provide the status of the account.
/// When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. 
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:|- contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or|- provide the status of the account.|When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. |When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
public partial record AccountDetailsConfirmationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_lUvrJ5DiEem7fvtoGpNpow")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_lUvrKZDiEem7fvtoGpNpow")]
    [Description(@"Identifies a related order or settlement transaction.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public SomeOrderReferenceRecord? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_lUvrK5DiEem7fvtoGpNpow")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_lUvrLZDiEem7fvtoGpNpow")]
    [Description(@"Information about the request or instruction which triggered this confirmation.")]
    [DataMember(Name="ConfDtls")]
    [XmlElement(ElementName="ConfDtls")]
    [Required]
    public required SomeConfirmationDetailsRecord ConfirmationDetails { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to the investment account.
    /// </summary>
    [IsoId("_lUvrL5DiEem7fvtoGpNpow")]
    [Description(@"Confirmation of the information related to the investment account.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    public SomeInvestmentAccountRecord? InvestmentAccount { get; init; }
    
    /// <summary>
    /// Confirmation of information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_lUvrMZDiEem7fvtoGpNpow")]
    [Description(@"Confirmation of information related to parties that are related to the account, for example, primary account owner.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    public SomeAccountPartiesRecord? AccountParties { get; init; }
    
    /// <summary>
    /// Confirmation of an intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_lUvrM5DiEem7fvtoGpNpow")]
    [Description(@"Confirmation of an intermediary or other party related to the management of the account.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public SomeIntermediariesRecord? Intermediaries { get; init; }
    
    /// <summary>
    /// Confirmation of referral information.
    /// </summary>
    [IsoId("_lUvrNZDiEem7fvtoGpNpow")]
    [Description(@"Confirmation of referral information.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public SomePlacementRecord? Placement { get; init; }
    
    /// <summary>
    /// Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_lUvrN5DiEem7fvtoGpNpow")]
    [Description(@"Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public SomeNewIssueAllocationRecord? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to the account.
    /// </summary>
    [IsoId("_lUvrOZDiEem7fvtoGpNpow")]
    [Description(@"Confirmation of the information related to a savings plan that is related to the account.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required IReadonlyCollection<SomeSavingsInvestmentPlanRecord> SavingsInvestmentPlan { get; init; } // Min=0, Max=50
    
    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to the account.
    /// </summary>
    [IsoId("_lUvrO5DiEem7fvtoGpNpow")]
    [Description(@"Confirmation of the information related to a withdrawal plan that is related to the account.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required IReadonlyCollection<SomeWithdrawalInvestmentPlanRecord> WithdrawalInvestmentPlan { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Confirmation of a cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_lUvrPZDiEem7fvtoGpNpow")]
    [Description(@"Confirmation of a cash settlement standing instruction associated to transactions on the account.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public required IReadonlyCollection<SomeCashSettlementRecord> CashSettlement { get; init; } // Min=0, Max=8
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_lUvrP5DiEem7fvtoGpNpow")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required IReadonlyCollection<SomeServiceLevelAgreementRecord> ServiceLevelAgreement { get; init; } // Min=0, Max=30
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
    /// </summary>
    [IsoId("_lUvrQZDiEem7fvtoGpNpow")]
    [Description(@"Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public SomeAdditionalInformationRecord? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_lUvrQ5DiEem7fvtoGpNpow")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public SomeMarketPracticeVersionRecord? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lUvrRZDiEem7fvtoGpNpow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountDetailsConfirmationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountDetailsConfirmationV08Document ToDocument()
    {
        return new AccountDetailsConfirmationV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountDetailsConfirmationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountDetailsConfirmationV08Document : IOuterDocument<AccountDetailsConfirmationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountDetailsConfirmationV08"/> is required.
    /// </summary>
    public required AccountDetailsConfirmationV08 Message { get; init; }
}
