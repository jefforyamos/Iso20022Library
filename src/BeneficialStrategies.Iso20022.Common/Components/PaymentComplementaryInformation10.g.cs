﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentComplementaryInformation10.  ISO2002 ID# _ggXkwdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further additional details on the underlying payment instruction that cannot be transferred in a regular statement message.
/// </summary>
public partial record PaymentComplementaryInformation10
     : IIsoXmlSerilizable<PaymentComplementaryInformation10>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public AmountType4Choice_? Amount { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount40? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    public SettlementInstruction11? SettlementInformation { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent3Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the debtor agent.
    /// </summary>
    public IsoMax140Text? InstructionForDebtorAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent.
    /// Usage: If more than one previous instructing agent is present, then PreviousInstructingAgent1 identifies the agent between the DebtorAgent and the PreviousInstructingAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent.
    /// Usage: If more than two previous instructing agent are present, then PreviousInstructingAgent2 identifies the agent between the PreviousInstructingAgent1 and the PreviousInstructingAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent.
    /// Usage: If PreviousInstructingAgent3 is present, then PreviousInstructingAgent3 identifies the agent between the PreviousInstructingAgent2 and the InstructingAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent 3 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent3Account { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    public InstructionForNextAgent1? InstructionForNextAgent { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    
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
        if (InstructionIdentification is IsoMax35Text InstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "InstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (EndToEndIdentification is IsoMax35Text EndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "EndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(EndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionIdentification is IsoMax35Text TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PaymentTypeInformation is PaymentTypeInformation27 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedExecutionDate is DateAndDateTime2Choice_ RequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
            RequestedExecutionDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedCollectionDate is IsoISODate RequestedCollectionDateValue)
        {
            writer.WriteStartElement(null, "ReqdColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InterbankSettlementDate is IsoISODate InterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Amount is AmountType4Choice_ AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            AmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterbankSettlementAmount is IsoActiveOrHistoricCurrencyAndAmount InterbankSettlementAmountValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(InterbankSettlementAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UltimateDebtor is PartyIdentification135 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Debtor is PartyIdentification135 DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAccount is CashAccount40 DebtorAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
            DebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgent is BranchAndFinancialInstitutionIdentification6 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgentAccount is CashAccount40 DebtorAgentAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAgtAcct", xmlNamespace );
            DebtorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementInformation is SettlementInstruction11 SettlementInformationValue)
        {
            writer.WriteStartElement(null, "SttlmInf", xmlNamespace );
            SettlementInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1Account is CashAccount40 IntermediaryAgent1AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt1Acct", xmlNamespace );
            IntermediaryAgent1AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2Account is CashAccount40 IntermediaryAgent2AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt2Acct", xmlNamespace );
            IntermediaryAgent2AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3Account is CashAccount40 IntermediaryAgent3AccountValue)
        {
            writer.WriteStartElement(null, "IntrmyAgt3Acct", xmlNamespace );
            IntermediaryAgent3AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification6 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgentAccount is CashAccount40 CreditorAgentAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAgtAcct", xmlNamespace );
            CreditorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is PartyIdentification135 CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAccount is CashAccount40 CreditorAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
            CreditorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is PartyIdentification135 UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Purpose is Purpose2Choice_ PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            PurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForDebtorAgent is IsoMax140Text InstructionForDebtorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForDbtrAgt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(InstructionForDebtorAgentValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent1 is BranchAndFinancialInstitutionIdentification6 PreviousInstructingAgent1Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt1", xmlNamespace );
            PreviousInstructingAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent1Account is CashAccount40 PreviousInstructingAgent1AccountValue)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt1Acct", xmlNamespace );
            PreviousInstructingAgent1AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent2 is BranchAndFinancialInstitutionIdentification6 PreviousInstructingAgent2Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt2", xmlNamespace );
            PreviousInstructingAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent2Account is CashAccount40 PreviousInstructingAgent2AccountValue)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt2Acct", xmlNamespace );
            PreviousInstructingAgent2AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent3 is BranchAndFinancialInstitutionIdentification6 PreviousInstructingAgent3Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt3", xmlNamespace );
            PreviousInstructingAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent3Account is CashAccount40 PreviousInstructingAgent3AccountValue)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt3Acct", xmlNamespace );
            PreviousInstructingAgent3AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForNextAgent is InstructionForNextAgent1 InstructionForNextAgentValue)
        {
            writer.WriteStartElement(null, "InstrForNxtAgt", xmlNamespace );
            InstructionForNextAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForCreditorAgent is InstructionForCreditorAgent3 InstructionForCreditorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForCdtrAgt", xmlNamespace );
            InstructionForCreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RltdRmtInf", xmlNamespace );
        RelatedRemittanceInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RemittanceInformation is RemittanceInformation21 RemittanceInformationValue)
        {
            writer.WriteStartElement(null, "RmtInf", xmlNamespace );
            RemittanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentComplementaryInformation10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
