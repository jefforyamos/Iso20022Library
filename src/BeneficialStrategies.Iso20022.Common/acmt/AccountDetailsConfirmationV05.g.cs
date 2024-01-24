﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountDetailsConfirmationV05.  ISO2002 ID# _o6vjsQgpEeSUG-8hqXsVMQ.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// An account servicer, for example, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer, for example, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.|When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
public partial record AccountDetailsConfirmationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_o6vjwwgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_o6vjxQgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies a related order.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public SomeOrderReferenceRecord? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_o6vjxwgpEeSUG-8hqXsVMQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// Provides detailed information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_o6vjyQgpEeSUG-8hqXsVMQ")]
    [Description(@"Provides detailed information about the request or instruction which triggered this confirmation.")]
    [DataMember(Name="ConfDtls")]
    [XmlElement(ElementName="ConfDtls")]
    [Required]
    public required SomeConfirmationDetailsRecord ConfirmationDetails { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjywgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of the information related to a selected investment account.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    public SomeInvestmentAccountRecord? InvestmentAccount { get; init; }
    
    /// <summary>
    /// Confirmation of information related to parties who are related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjzQgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of information related to parties who are related to a selected investment account.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    public SomeAccountPartiesRecord? AccountParties { get; init; }
    
    /// <summary>
    /// Confirmation of information related to intermediaries who are related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjzwgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of information related to intermediaries who are related to a selected investment account.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public required IReadonlyCollection<SomeIntermediariesRecord> Intermediaries { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_o6vj0QgpEeSUG-8hqXsVMQ")]
    [Description(@"Placement agent for the hedge fund industry.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public SomePlacementRecord? Placement { get; init; }
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_o6vj0wgpEeSUG-8hqXsVMQ")]
    [Description(@"Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public SomeNewIssueAllocationRecord? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o6vj1QgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of the information related to a savings plan that is related to a selected investment account.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required IReadonlyCollection<SomeSavingsInvestmentPlanRecord> SavingsInvestmentPlan { get; init; } // Min=0, Max=50
    
    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o6vj1wgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of the information related to a withdrawal plan that is related to a selected investment account.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required IReadonlyCollection<SomeWithdrawalInvestmentPlanRecord> WithdrawalInvestmentPlan { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Confirmation of the cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_o6vj2QgpEeSUG-8hqXsVMQ")]
    [Description(@"Confirmation of the cash settlement standing instruction associated to the investment fund transaction.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public required IReadonlyCollection<SomeCashSettlementRecord> CashSettlement { get; init; } // Min=0, Max=8
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_o6vj2wgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required IReadonlyCollection<SomeServiceLevelAgreementRecord> ServiceLevelAgreement { get; init; } // Min=0, Max=30
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_o6vj3QgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public SomeMarketPracticeVersionRecord? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_o6vj3wgpEeSUG-8hqXsVMQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountDetailsConfirmationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountDetailsConfirmationV05Document ToDocument()
    {
        return new AccountDetailsConfirmationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountDetailsConfirmationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountDetailsConfirmationV05Document : IOuterDocument<AccountDetailsConfirmationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountDetailsConfirmationV05"/> is required.
    /// </summary>
    public required AccountDetailsConfirmationV05 Message { get; init; }
}
