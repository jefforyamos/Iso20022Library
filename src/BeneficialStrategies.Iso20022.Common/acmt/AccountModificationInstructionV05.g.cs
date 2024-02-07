﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountModificationInstructionV05.  ISO2002 ID# _rM_TIQgpEeSUG-8hqXsVMQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountModificationInstructionV05>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.003.001.05 ISO standard message type.
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
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the AccountModificationInstruction message to the account servicer, for example, a registrar, transfer agent or custodian bank to modify, that is, create, update or delete specific details of an existing investment fund account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message has three specific uses:|- to maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- to add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,|- to delete specific account details, for example, delete cash standing instructions.|This message cannot be used to delete an entire account, as institution specific and regulatory rules pertaining to account deletion are diverse.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountModificationInstructionV05 : IOuterRecord<AccountModificationInstructionV05,AccountModificationInstructionV05Document>
    ,IIsoXmlSerilizable<AccountModificationInstructionV05>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountModificationInstructionV05Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_rM_TMQgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_rM_TMwgpEeSUG-8hqXsVMQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Provides detailed information about the application modification instruction.
    /// </summary>
    [IsoId("_rM_TNQgpEeSUG-8hqXsVMQ")]
    [Description(@"Provides detailed information about the application modification instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    public InvestmentAccountModification1? InstructionDetails { get; init; }
    
    /// <summary>
    /// Investment account selection information used to identify the account for which the information is modified.
    /// </summary>
    [IsoId("_rM_TNwgpEeSUG-8hqXsVMQ")]
    [Description(@"Investment account selection information used to identify the account for which the information is modified.")]
    [DataMember(Name="InvstmtAcctSelctn")]
    [XmlElement(ElementName="InvstmtAcctSelctn")]
    [Required]
    public required InvestmentAccountSelection2 InvestmentAccountSelection { get; init; }
    
    /// <summary>
    /// Information related to general characteristics of an investment account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TOQgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to general characteristics of an investment account to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdInvstmtAcct")]
    [XmlElement(ElementName="ModfdInvstmtAcct")]
    public InvestmentAccount47? ModifiedInvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to the account related parties, for example, primary owner to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TOwgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to the account related parties, for example, primary owner to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdAcctPties")]
    [XmlElement(ElementName="ModfdAcctPties")]
    public required ValueList<AccountParties11> ModifiedAccountParties { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TPQgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to intermediaries to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIntrmies")]
    [XmlElement(ElementName="ModfdIntrmies")]
    public required ValueList<ModificationScope20> ModifiedIntermediaries { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TPwgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to referred placement agent in the hedge fund industry to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdPlcmnt")]
    [XmlElement(ElementName="ModfdPlcmnt")]
    public ReferredAgent1? ModifiedPlacement { get; init; }
    
    /// <summary>
    /// Eligibility conditions information related to new issues allocation to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TQQgpEeSUG-8hqXsVMQ")]
    [Description(@"Eligibility conditions information related to new issues allocation to be inserted, updated or deleted.")]
    [DataMember(Name="ModfdIsseAllcn")]
    [XmlElement(ElementName="ModfdIsseAllcn")]
    public ModificationScope21? ModifiedIssueAllocation { get; init; }
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TQwgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to a savings plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    [XmlElement(ElementName="ModfdSvgsInvstmtPlan")]
    public required ValueList<ModificationScope25> ModifiedSavingsInvestmentPlan { get; init; } = []; // Min=0, Max=50
    
    /// <summary>
    /// Information related to a withdrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_rM_TRQgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to a withdrawal plan to be either inserted, updated or deleted.")]
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    [XmlElement(ElementName="ModfdWdrwlInvstmtPlan")]
    public required ValueList<ModificationScope25> ModifiedWithdrawalInvestmentPlan { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.
    /// </summary>
    [IsoId("_rM_TRwgpEeSUG-8hqXsVMQ")]
    [Description(@"Cash settlement standing instruction associated to the investment fund transaction and to be either inserted or deleted.")]
    [DataMember(Name="ModfdCshSttlm")]
    [XmlElement(ElementName="ModfdCshSttlm")]
    public required ValueList<InvestmentFundCashSettlementInformation8> ModifiedCashSettlement { get; init; } = []; // Min=0, Max=8
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("_rM_TSQgpEeSUG-8hqXsVMQ")]
    [Description(@"Information related to documents to be added, deleted or updated.|.")]
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    [XmlElement(ElementName="ModfdSvcLvlAgrmt")]
    public required ValueList<ModificationScope22> ModifiedServiceLevelAgreement { get; init; } = []; // Min=0, Max=30
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_rM_TSwgpEeSUG-8hqXsVMQ")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rM_TTQgpEeSUG-8hqXsVMQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountModificationInstructionV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountModificationInstructionV05Document ToDocument()
    {
        return new AccountModificationInstructionV05Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctModInstr");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        MessageIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviousReference is AdditionalReference3 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionDetails is InvestmentAccountModification1 InstructionDetailsValue)
        {
            writer.WriteStartElement(null, "InstrDtls", xmlNamespace );
            InstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InvstmtAcctSelctn", xmlNamespace );
        InvestmentAccountSelection.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ModifiedInvestmentAccount is InvestmentAccount47 ModifiedInvestmentAccountValue)
        {
            writer.WriteStartElement(null, "ModfdInvstmtAcct", xmlNamespace );
            ModifiedInvestmentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ModfdAcctPties", xmlNamespace );
        ModifiedAccountParties.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ModfdIntrmies", xmlNamespace );
        ModifiedIntermediaries.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ModifiedPlacement is ReferredAgent1 ModifiedPlacementValue)
        {
            writer.WriteStartElement(null, "ModfdPlcmnt", xmlNamespace );
            ModifiedPlacementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ModifiedIssueAllocation is ModificationScope21 ModifiedIssueAllocationValue)
        {
            writer.WriteStartElement(null, "ModfdIsseAllcn", xmlNamespace );
            ModifiedIssueAllocationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ModfdSvgsInvstmtPlan", xmlNamespace );
        ModifiedSavingsInvestmentPlan.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ModfdWdrwlInvstmtPlan", xmlNamespace );
        ModifiedWithdrawalInvestmentPlan.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ModfdCshSttlm", xmlNamespace );
        ModifiedCashSettlement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ModfdSvcLvlAgrmt", xmlNamespace );
        ModifiedServiceLevelAgreement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarketPracticeVersion is MarketPracticeVersion1 MarketPracticeVersionValue)
        {
            writer.WriteStartElement(null, "MktPrctcVrsn", xmlNamespace );
            MarketPracticeVersionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountModificationInstructionV05 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountModificationInstructionV05"/>.
/// </summary>
[Serializable]
public partial record AccountModificationInstructionV05Document : IOuterDocument<AccountModificationInstructionV05>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountModificationInstructionV05"/> is required.
    /// </summary>
    [DataMember(Name=AccountModificationInstructionV05.XmlTag)]
    public required AccountModificationInstructionV05 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountModificationInstructionV05.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
