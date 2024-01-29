﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningInstructionV02.  ISO2002 ID# _uPJGqNE9Ed-BzquC8wXy7w_374979403.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to an account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to an account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountOpeningInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstrV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_uPJGqdE9Ed-BzquC8wXy7w_-732849931")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_uPJGqtE9Ed-BzquC8wXy7w_-1194676409")]
    [Description(@"Identifies a related order.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public SomeOrderReferenceRecord? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_uPJGq9E9Ed-BzquC8wXy7w_374981384")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Provide detailed information about the opening instruction.
    /// </summary>
    [IsoId("_uPSQkNE9Ed-BzquC8wXy7w_374981349")]
    [Description(@"Provide detailed information about the opening instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    [Required]
    public required SomeInstructionDetailsRecord InstructionDetails { get; init; }
    
    /// <summary>
    /// Detailed information about the investment account to be opened.
    /// </summary>
    [IsoId("_uPSQkdE9Ed-BzquC8wXy7w_374979807")]
    [Description(@"Detailed information about the investment account to be opened.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    [Required]
    public required SomeInvestmentAccountRecord InvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to parties who are related to an investment account; eg. primary account owner.
    /// </summary>
    [IsoId("_uPSQktE9Ed-BzquC8wXy7w_374979944")]
    [Description(@"Information related to parties who are related to an investment account; eg. primary account owner.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    [Required]
    public required SomeAccountPartiesRecord AccountParties { get; init; }
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_uPSQk9E9Ed-BzquC8wXy7w_374980359")]
    [Description(@"Information related to an intermediary.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public required IReadonlyCollection<SomeIntermediariesRecord> Intermediaries { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_uPSQlNE9Ed-BzquC8wXy7w_374980316")]
    [Description(@"Placement agent for the hedge fund industry.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public SomePlacementRecord? Placement { get; init; }
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_uPSQldE9Ed-BzquC8wXy7w_374980737")]
    [Description(@"Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public SomeNewIssueAllocationRecord? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, eg, retirement.
    /// </summary>
    [IsoId("_uPSQltE9Ed-BzquC8wXy7w_374979849")]
    [Description(@"Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, eg, retirement.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required IReadonlyCollection<SomeSavingsInvestmentPlanRecord> SavingsInvestmentPlan { get; init; } // Min=0, Max=50
    
    /// <summary>
    /// Plan through which an investment fund investor's holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_uPSQl9E9Ed-BzquC8wXy7w_374979909")]
    [Description(@"Plan through which an investment fund investor's holdings are depleted through regular withdrawals at specified intervals.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required IReadonlyCollection<SomeWithdrawalInvestmentPlanRecord> WithdrawalInvestmentPlan { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_uPSQmNE9Ed-BzquC8wXy7w_374980394")]
    [Description(@"Cash settlement standing instruction associated to the investment fund transaction.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public SomeCashSettlementRecord? CashSettlement { get; init; }
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_uPcBkNE9Ed-BzquC8wXy7w_374980454")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required IReadonlyCollection<SomeServiceLevelAgreementRecord> ServiceLevelAgreement { get; init; } // Min=0, Max=30
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_uPcBkdE9Ed-BzquC8wXy7w_374980797")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningInstructionV02Document ToDocument()
    {
        return new AccountOpeningInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningInstructionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountOpeningInstructionV02Document : IOuterDocument<AccountOpeningInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningInstructionV02"/> is required.
    /// </summary>
    public required AccountOpeningInstructionV02 Message { get; init; }
}