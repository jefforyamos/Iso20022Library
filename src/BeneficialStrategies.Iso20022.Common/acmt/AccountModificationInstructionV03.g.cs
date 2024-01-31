﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountModificationInstructionV03.  ISO2002 ID# _DSWQgRGzEeKVqeHljBM1MQ.
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
/// This record is an implementation of the acmt.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent or custodian bank to modify, that is, create, update or delete specific details of an existing investment fund account.
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
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent or custodian bank to modify, that is, create, update or delete specific details of an existing investment fund account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message has three specific uses:|- to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,|- to delete specific account details, for example, delete cash standing instructions.|This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountModificationInstructionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_DSWQgxGzEeKVqeHljBM1MQ")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_DSWQhxGzEeKVqeHljBM1MQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Provide detailed information about the application modification instruction.
    /// </summary>
    [IsoId("_DSWQixGzEeKVqeHljBM1MQ")]
    [Description(@"Provide detailed information about the application modification instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    public InvestmentAccountModificationDetails? InstructionDetails { get; init; }
    
    /// <summary>
    /// Investment account selection information used to identify the account for which the information is modified.
    /// </summary>
    [IsoId("_DSWQjxGzEeKVqeHljBM1MQ")]
    [Description(@"Investment account selection information used to identify the account for which the information is modified.")]
    [DataMember(Name="InvstmtAcctSelctn")]
    [XmlElement(ElementName="InvstmtAcctSelctn")]
    [Required]
    public required InvestmentAccountSelection2 InvestmentAccountSelection { get; init; }
    
    /// <summary>
    /// Information related to general characteristics of an investment account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQkxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to general characteristics of an investment account to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdInvstmtAcct")]
    [XmlElement(ElementName="ModfdInvstmtAcct")]
    public InvestmentAccount36? ModifiedInvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to the account related parties (eg. account owner) to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQlxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to the account related parties (eg. account owner) to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdAcctPties")]
    [XmlElement(ElementName="ModfdAcctPties")]
    public required IReadOnlyCollection<AccountParties7> ModifiedAccountParties { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQmxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to intermediaries to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIntrmies")]
    [XmlElement(ElementName="ModfdIntrmies")]
    public required IReadOnlyCollection<ModificationScope7> ModifiedIntermediaries { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQnxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdPlcmnt")]
    [XmlElement(ElementName="ModfdPlcmnt")]
    public ReferredAgent1? ModifiedPlacement { get; init; }
    
    /// <summary>
    /// Eligibility conditions information related to new issues allocation to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQoxGzEeKVqeHljBM1MQ")]
    [Description(@"Eligibility conditions information related to new issues allocation to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIsseAllcn")]
    [XmlElement(ElementName="ModfdIsseAllcn")]
    public ModificationScope9? ModifiedIssueAllocation { get; init; }
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQpxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to a savings plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    [XmlElement(ElementName="ModfdSvgsInvstmtPlan")]
    public required IReadOnlyCollection<ModificationScope16> ModifiedSavingsInvestmentPlan { get; init; } = []; // Min=0, Max=50
    
    /// <summary>
    /// Information related to a withdrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_DSWQqxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to a withdrawal plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    [XmlElement(ElementName="ModfdWdrwlInvstmtPlan")]
    public required IReadOnlyCollection<ModificationScope16> ModifiedWithdrawalInvestmentPlan { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.
    /// </summary>
    [IsoId("_DSWQrxGzEeKVqeHljBM1MQ")]
    [Description(@"Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.")]
    [DataMember(Name="ModfdCshSttlm")]
    [XmlElement(ElementName="ModfdCshSttlm")]
    public required IReadOnlyCollection<InvestmentFundCashSettlementInformation6> ModifiedCashSettlement { get; init; } = []; // Min=0, Max=8
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("_DSWQsxGzEeKVqeHljBM1MQ")]
    [Description(@"Information related to documents to be added, deleted or updated.|.")]
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    [XmlElement(ElementName="ModfdSvcLvlAgrmt")]
    public required IReadOnlyCollection<ModificationScope10> ModifiedServiceLevelAgreement { get; init; } = []; // Min=0, Max=30
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DSWQtxGzEeKVqeHljBM1MQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountModificationInstructionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountModificationInstructionV03Document ToDocument()
    {
        return new AccountModificationInstructionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountModificationInstructionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountModificationInstructionV03Document : IOuterDocument<AccountModificationInstructionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountModificationInstructionV03"/> is required.
    /// </summary>
    public required AccountModificationInstructionV03 Message { get; init; }
}
