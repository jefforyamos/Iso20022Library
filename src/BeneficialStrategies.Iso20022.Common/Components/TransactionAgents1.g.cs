﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionAgents1.  ISO2002 ID# _PyefZdp-Ed-ak6NoX_4Aeg_868982411.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
public partial record TransactionAgents1
     : IIsoXmlSerilizable<TransactionAgents1>
{
    #nullable enable
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the debtor agent and the intermediary agent 2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the intermediary agent 1 and the intermediary agent 3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Agent between the debtor agent and creditor agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the intermediary agent 2 and the creditor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? ReceivingAgent { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.|Can also be used in the context of treasury operations.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? DeliveringAgent { get; init; } 
    /// <summary>
    /// Legal entity that has the right to issue securities.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? IssuingAgent { get; init; } 
    /// <summary>
    /// Place where settlement of the securities takes place.||Note: this is typed by a financial institution identification - as this is the standard way of identifying eg securities settlement agent/central system.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? SettlementPlace { get; init; } 
    /// <summary>
    /// Proprietary agent related to the underlying transaction.
    /// </summary>
    public ProprietaryAgent1? Proprietary { get; init; } 
    
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
        if (DebtorAgent is BranchAndFinancialInstitutionIdentification3 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditorAgent is BranchAndFinancialInstitutionIdentification3 CreditorAgentValue)
        {
            writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
            CreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent1 is BranchAndFinancialInstitutionIdentification3 IntermediaryAgent1Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt1", xmlNamespace );
            IntermediaryAgent1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent2 is BranchAndFinancialInstitutionIdentification3 IntermediaryAgent2Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt2", xmlNamespace );
            IntermediaryAgent2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IntermediaryAgent3 is BranchAndFinancialInstitutionIdentification3 IntermediaryAgent3Value)
        {
            writer.WriteStartElement(null, "IntrmyAgt3", xmlNamespace );
            IntermediaryAgent3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceivingAgent is BranchAndFinancialInstitutionIdentification3 ReceivingAgentValue)
        {
            writer.WriteStartElement(null, "RcvgAgt", xmlNamespace );
            ReceivingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringAgent is BranchAndFinancialInstitutionIdentification3 DeliveringAgentValue)
        {
            writer.WriteStartElement(null, "DlvrgAgt", xmlNamespace );
            DeliveringAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuingAgent is BranchAndFinancialInstitutionIdentification3 IssuingAgentValue)
        {
            writer.WriteStartElement(null, "IssgAgt", xmlNamespace );
            IssuingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementPlace is BranchAndFinancialInstitutionIdentification3 SettlementPlaceValue)
        {
            writer.WriteStartElement(null, "SttlmPlc", xmlNamespace );
            SettlementPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Proprietary is ProprietaryAgent1 ProprietaryValue)
        {
            writer.WriteStartElement(null, "Prtry", xmlNamespace );
            ProprietaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionAgents1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
