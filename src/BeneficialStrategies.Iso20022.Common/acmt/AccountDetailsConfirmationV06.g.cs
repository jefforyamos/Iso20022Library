﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountDetailsConfirmationV06.  ISO2002 ID# _9y4qQR8KEeWpZde3LQh6dg.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// An account servicer, for example, a registrar, transfer agent, custodian bank or securities depository sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer, for example, a registrar, transfer agent, custodian bank or securities depository sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.|When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
public partial record AccountDetailsConfirmationV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_9y4qUx8KEeWpZde3LQh6dg")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_9y4qVR8KEeWpZde3LQh6dg")]
    [Description(@"Identifies a related order or settlement transaction.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9y4qVx8KEeWpZde3LQh6dg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; }
    
    /// <summary>
    /// Information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_9y4qWR8KEeWpZde3LQh6dg")]
    [Description(@"Information about the request or instruction which triggered this confirmation.")]
    [DataMember(Name="ConfDtls")]
    [XmlElement(ElementName="ConfDtls")]
    [Required]
    public required AccountManagementConfirmation3 ConfirmationDetails { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to the investment account.
    /// </summary>
    [IsoId("_9y4qWx8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of the information related to the investment account.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    public InvestmentAccount50? InvestmentAccount { get; init; }
    
    /// <summary>
    /// Confirmation of information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_9y4qXR8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of information related to parties that are related to the account, for example, primary account owner.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    public AccountParties13? AccountParties { get; init; }
    
    /// <summary>
    /// Confirmation of an intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the 'account controller'.
    /// </summary>
    [IsoId("_9y4qXx8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of an intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the 'account controller'.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public required IReadonlyCollection<Intermediary36> Intermediaries { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Confirmation of referral information.
    /// </summary>
    [IsoId("_9y4qYR8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of referral information.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public ReferredAgent2? Placement { get; init; }
    
    /// <summary>
    /// Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_9y4qYx8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to the account.
    /// </summary>
    [IsoId("_9y4qZR8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of the information related to a savings plan that is related to the account.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required IReadonlyCollection<InvestmentPlan12> SavingsInvestmentPlan { get; init; } // Min=0, Max=50
    
    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to the account.
    /// </summary>
    [IsoId("_9y4qZx8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of the information related to a withdrawal plan that is related to the account.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required IReadonlyCollection<InvestmentPlan12> WithdrawalInvestmentPlan { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Confirmation of a cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_9y4qaR8KEeWpZde3LQh6dg")]
    [Description(@"Confirmation of a cash settlement standing instruction associated to transactions on the account.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public required IReadonlyCollection<CashSettlement1> CashSettlement { get; init; } // Min=0, Max=8
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_9y4qax8KEeWpZde3LQh6dg")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required IReadonlyCollection<DocumentToSend3> ServiceLevelAgreement { get; init; } // Min=0, Max=30
    
    /// <summary>
    /// Additional information concerning limitations and restrictions on the account.
    /// </summary>
    [IsoId("_JMKmwSFoEeW9XJWqfgXIIA")]
    [Description(@"Additional information concerning limitations and restrictions on the account.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public AccountRestrictions1? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9y4qbR8KEeWpZde3LQh6dg")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9y4qbx8KEeWpZde3LQh6dg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountDetailsConfirmationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountDetailsConfirmationV06Document ToDocument()
    {
        return new AccountDetailsConfirmationV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountDetailsConfirmationV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountDetailsConfirmationV06Document : IOuterDocument<AccountDetailsConfirmationV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountDetailsConfirmationV06"/> is required.
    /// </summary>
    public required AccountDetailsConfirmationV06 Message { get; init; }
}
