﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionParties5.  ISO2002 ID# _YL0nEYauEeeUws0ZryHQ2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the parties specific to the individual transaction.
/// </summary>
public partial record TransactionParties5
     : IIsoXmlSerilizable<TransactionParties5>
{
    #nullable enable
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party35Choice_? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required Party35Choice_ Debtor { get; init; } 
    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    public Party35Choice_? InitiatingParty { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; } 
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; } 
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required Party35Choice_ Creditor { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public Party35Choice_? UltimateCreditor { get; init; } 
    
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
        if (UltimateDebtor is Party35Choice_ UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Dbtr", xmlNamespace );
        Debtor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InitiatingParty is Party35Choice_ InitiatingPartyValue)
        {
            writer.WriteStartElement(null, "InitgPty", xmlNamespace );
            InitiatingPartyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgent is BranchAndFinancialInstitutionIdentification5 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent1 is BranchAndFinancialInstitutionIdentification5 PreviousInstructingAgent1Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt1", xmlNamespace );
            PreviousInstructingAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent2 is BranchAndFinancialInstitutionIdentification5 PreviousInstructingAgent2Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt2", xmlNamespace );
            PreviousInstructingAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousInstructingAgent3 is BranchAndFinancialInstitutionIdentification5 PreviousInstructingAgent3Value)
        {
            writer.WriteStartElement(null, "PrvsInstgAgt3", xmlNamespace );
            PreviousInstructingAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification5 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification5 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Cdtr", xmlNamespace );
        Creditor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UltimateCreditor is Party35Choice_ UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionParties5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
