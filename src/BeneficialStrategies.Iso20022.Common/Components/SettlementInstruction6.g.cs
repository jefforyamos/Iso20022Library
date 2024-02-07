﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInstruction6.  ISO2002 ID# _FkoOoW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
public partial record SettlementInstruction6
     : IIsoXmlSerilizable<SettlementInstruction6>
{
    #nullable enable
    
    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructingReimbursementAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? InstructingReimbursementAgentAccount { get; init; } 
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructedReimbursementAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? InstructedReimbursementAgentAccount { get; init; } 
    
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
        if (InstructingReimbursementAgent is BranchAndFinancialInstitutionIdentification6 InstructingReimbursementAgentValue)
        {
            writer.WriteStartElement(null, "InstgRmbrsmntAgt", xmlNamespace );
            InstructingReimbursementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructingReimbursementAgentAccount is CashAccount38 InstructingReimbursementAgentAccountValue)
        {
            writer.WriteStartElement(null, "InstgRmbrsmntAgtAcct", xmlNamespace );
            InstructingReimbursementAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedReimbursementAgent is BranchAndFinancialInstitutionIdentification6 InstructedReimbursementAgentValue)
        {
            writer.WriteStartElement(null, "InstdRmbrsmntAgt", xmlNamespace );
            InstructedReimbursementAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedReimbursementAgentAccount is CashAccount38 InstructedReimbursementAgentAccountValue)
        {
            writer.WriteStartElement(null, "InstdRmbrsmntAgtAcct", xmlNamespace );
            InstructedReimbursementAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementInstruction6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
