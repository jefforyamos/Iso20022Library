﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountOpeningInstructionV04.  ISO2002 ID# _A0sdwBQ6EeOKWo1NF21OVw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.acmt.AccountOpeningInstructionV04>;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// This record is an implementation of the acmt.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Serializable]
[Description(@"Scope|An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
public partial record AccountOpeningInstructionV04 : IOuterRecord<AccountOpeningInstructionV04,AccountOpeningInstructionV04Document>
    ,IIsoXmlSerilizable<AccountOpeningInstructionV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstr";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AccountOpeningInstructionV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_A0sd0hQ6EeOKWo1NF21OVw")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_A0sd1BQ6EeOKWo1NF21OVw")]
    [Description(@"Identifies a related order.")]
    [DataMember(Name="OrdrRef")]
    [XmlElement(ElementName="OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_A0sd1hQ6EeOKWo1NF21OVw")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Provides detailed information about the opening instruction.
    /// </summary>
    [IsoId("_A0sd2BQ6EeOKWo1NF21OVw")]
    [Description(@"Provides detailed information about the opening instruction.")]
    [DataMember(Name="InstrDtls")]
    [XmlElement(ElementName="InstrDtls")]
    [Required]
    public required InvestmentAccountOpeningDetails InstructionDetails { get; init; }
    
    /// <summary>
    /// Detailed information about the investment account to be opened.
    /// </summary>
    [IsoId("_A0sd2hQ6EeOKWo1NF21OVw")]
    [Description(@"Detailed information about the investment account to be opened.")]
    [DataMember(Name="InvstmtAcct")]
    [XmlElement(ElementName="InvstmtAcct")]
    [Required]
    public required InvestmentAccount37 InvestmentAccount { get; init; }
    
    /// <summary>
    /// Information related to parties who are related to an investment account, for example, primary account owner.
    /// </summary>
    [IsoId("_A0sd3BQ6EeOKWo1NF21OVw")]
    [Description(@"Information related to parties who are related to an investment account, for example, primary account owner.")]
    [DataMember(Name="AcctPties")]
    [XmlElement(ElementName="AcctPties")]
    [Required]
    public required AccountParties9 AccountParties { get; init; }
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_A0sd3hQ6EeOKWo1NF21OVw")]
    [Description(@"Information related to an intermediary.")]
    [DataMember(Name="Intrmies")]
    [XmlElement(ElementName="Intrmies")]
    public required ValueList<Intermediary24> Intermediaries { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_A0sd4BQ6EeOKWo1NF21OVw")]
    [Description(@"Placement agent for the hedge fund industry.")]
    [DataMember(Name="Plcmnt")]
    [XmlElement(ElementName="Plcmnt")]
    public ReferredAgent1? Placement { get; init; }
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_A0sd4hQ6EeOKWo1NF21OVw")]
    [Description(@"Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.")]
    [DataMember(Name="NewIsseAllcn")]
    [XmlElement(ElementName="NewIsseAllcn")]
    public NewIssueAllocation1? NewIssueAllocation { get; init; }
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_A0sd5BQ6EeOKWo1NF21OVw")]
    [Description(@"Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.")]
    [DataMember(Name="SvgsInvstmtPlan")]
    [XmlElement(ElementName="SvgsInvstmtPlan")]
    public required ValueList<InvestmentPlan9> SavingsInvestmentPlan { get; init; } = []; // Min=0, Max=50
    
    /// <summary>
    /// Plan through which an investment fund investor's holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_A0sd5hQ6EeOKWo1NF21OVw")]
    [Description(@"Plan through which an investment fund investor's holdings are depleted through regular withdrawals at specified intervals.")]
    [DataMember(Name="WdrwlInvstmtPlan")]
    [XmlElement(ElementName="WdrwlInvstmtPlan")]
    public required ValueList<InvestmentPlan9> WithdrawalInvestmentPlan { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_A0sd6BQ6EeOKWo1NF21OVw")]
    [Description(@"Cash settlement standing instruction associated to the investment fund transaction.")]
    [DataMember(Name="CshSttlm")]
    [XmlElement(ElementName="CshSttlm")]
    public required ValueList<InvestmentFundCashSettlementInformation7> CashSettlement { get; init; } = []; // Min=0, Max=8
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_A0sd6hQ6EeOKWo1NF21OVw")]
    [Description(@"Identifies documents to be provided for the account opening.")]
    [DataMember(Name="SvcLvlAgrmt")]
    [XmlElement(ElementName="SvcLvlAgrmt")]
    public required ValueList<DocumentToSend1> ServiceLevelAgreement { get; init; } = []; // Min=0, Max=30
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_uLyU8RUVEeOIaq8KyCdIDQ")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_A0sd7BQ6EeOKWo1NF21OVw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountOpeningInstructionV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountOpeningInstructionV04Document ToDocument()
    {
        return new AccountOpeningInstructionV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("AcctOpngInstr");
    
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
        if (OrderReference is InvestmentFundOrder4 OrderReferenceValue)
        {
            writer.WriteStartElement(null, "OrdrRef", xmlNamespace );
            OrderReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousReference is AdditionalReference3 PreviousReferenceValue)
        {
            writer.WriteStartElement(null, "PrvsRef", xmlNamespace );
            PreviousReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstrDtls", xmlNamespace );
        InstructionDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InvstmtAcct", xmlNamespace );
        InvestmentAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctPties", xmlNamespace );
        AccountParties.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Intrmies", xmlNamespace );
        Intermediaries.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Placement is ReferredAgent1 PlacementValue)
        {
            writer.WriteStartElement(null, "Plcmnt", xmlNamespace );
            PlacementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewIssueAllocation is NewIssueAllocation1 NewIssueAllocationValue)
        {
            writer.WriteStartElement(null, "NewIsseAllcn", xmlNamespace );
            NewIssueAllocationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SvgsInvstmtPlan", xmlNamespace );
        SavingsInvestmentPlan.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "WdrwlInvstmtPlan", xmlNamespace );
        WithdrawalInvestmentPlan.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CshSttlm", xmlNamespace );
        CashSettlement.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SvcLvlAgrmt", xmlNamespace );
        ServiceLevelAgreement.Serialize(writer, xmlNamespace);
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
    public static AccountOpeningInstructionV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountOpeningInstructionV04"/>.
/// </summary>
[Serializable]
public partial record AccountOpeningInstructionV04Document : IOuterDocument<AccountOpeningInstructionV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountOpeningInstructionV04"/> is required.
    /// </summary>
    [DataMember(Name=AccountOpeningInstructionV04.XmlTag)]
    public required AccountOpeningInstructionV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(AccountOpeningInstructionV04.XmlTag);
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
