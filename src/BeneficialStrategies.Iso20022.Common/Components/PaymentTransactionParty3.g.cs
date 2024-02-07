﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionParty3.  ISO2002 ID# __cH_c249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the party fields used to search for a payment.
/// </summary>
public partial record PaymentTransactionParty3
     : IIsoXmlSerilizable<PaymentTransactionParty3>
{
    #nullable enable
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party40Choice_? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that owes assets to the creditor, such as a result of receipt of goods or services, gifts, or charity payments. The debtor may also be the debit account owner.
    /// </summary>
    public Party40Choice_? Debtor { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Specifies the agent through which the instructing agent will reimburse the instructed agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; } 
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, or other nominated party, and credits the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public Party40Choice_? Creditor { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public Party40Choice_? UltimateCreditor { get; init; } 
    
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
        if (InstructingAgent is BranchAndFinancialInstitutionIdentification6 InstructingAgentValue)
        {
            writer.WriteStartElement(null, "InstgAgt", xmlNamespace );
            InstructingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedAgent is BranchAndFinancialInstitutionIdentification6 InstructedAgentValue)
        {
            writer.WriteStartElement(null, "InstdAgt", xmlNamespace );
            InstructedAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is Party40Choice_ UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Debtor is Party40Choice_ DebtorValue)
        {
            writer.WriteStartElement(null, "Dbtr", xmlNamespace );
            DebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgent is BranchAndFinancialInstitutionIdentification6 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructingReimbursementAgent is BranchAndFinancialInstitutionIdentification6 InstructingReimbursementAgentValue)
        {
            writer.WriteStartElement(null, "InstgRmbrsmntAgt", xmlNamespace );
            InstructingReimbursementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedReimbursementAgent is BranchAndFinancialInstitutionIdentification6 InstructedReimbursementAgentValue)
        {
            writer.WriteStartElement(null, "InstdRmbrsmntAgt", xmlNamespace );
            InstructedReimbursementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification6 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification6 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Creditor is Party40Choice_ CreditorValue)
        {
            writer.WriteStartElement(null, "Cdtr", xmlNamespace );
            CreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is Party40Choice_ UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransactionParty3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
