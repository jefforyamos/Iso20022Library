﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransferTransaction26.  ISO2002 ID# _213P4Tq4EeWZFYSPlduMhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information specific to the individual transaction(s) included in the message.
/// </summary>
public partial record CreditTransferTransaction26
     : IIsoXmlSerilizable<CreditTransferTransaction26>
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    public required PaymentIdentification1 PaymentIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required AmountType4Choice_ Amount { get; init; } 
    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    public Cheque7? ChequeInstruction { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification43? UltimateDebtor { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? IntermediaryAgent3Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public CashAccount24? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentification43? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount24? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification43? UltimateCreditor { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// </summary>
    public IsoMax140Text? InstructionForDebtorAgent { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation3? Tax { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public ValueList<RemittanceLocation4> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation11? RemittanceInformation { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "PmtId", xmlNamespace );
        PaymentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentTypeInformation is PaymentTypeInformation19 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ExchangeRateInformation is ExchangeRate1 ExchangeRateInformationValue)
        {
            writer.WriteStartElement(null, "XchgRateInf", xmlNamespace );
            ExchangeRateInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChequeInstruction is Cheque7 ChequeInstructionValue)
        {
            writer.WriteStartElement(null, "ChqInstr", xmlNamespace );
            ChequeInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is PartyIdentification43 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1Account is CashAccount24 IntermediaryAgent1AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt1Acct", xmlNamespace );
            IntermediaryAgent1AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2Account is CashAccount24 IntermediaryAgent2AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt2Acct", xmlNamespace );
            IntermediaryAgent2AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3Account is CashAccount24 IntermediaryAgent3AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt3Acct", xmlNamespace );
            IntermediaryAgent3AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification5 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgentAccount is CashAccount24 CreditorAgentAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAgtAcct", xmlNamespace );
            CreditorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is PartyIdentification43 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAccount is CashAccount24 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is PartyIdentification43 UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForCreditorAgent is InstructionForCreditorAgent1 InstructionForCreditorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForCdtrAgt", xmlNamespace );
            InstructionForCreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForDebtorAgent is IsoMax140Text InstructionForDebtorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForDbtrAgt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(InstructionForDebtorAgentValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (Purpose is Purpose2Choice_ PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            PurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RgltryRptg", xmlNamespace );
        RegulatoryReporting.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Tax is TaxInformation3 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RltdRmtInf", xmlNamespace );
        RelatedRemittanceInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RemittanceInformation is RemittanceInformation11 RemittanceInformationValue)
        {
            writer.WriteStartElement(null, "RmtInf", xmlNamespace );
            RemittanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CreditTransferTransaction26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
