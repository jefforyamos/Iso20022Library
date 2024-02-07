﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionCounterpartyData11.  ISO2002 ID# _Z3Woocg4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details related to the parties involved in the securities lending transaction.
/// </summary>
public partial record TransactionCounterpartyData11
     : IIsoXmlSerilizable<TransactionCounterpartyData11>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    public PartyIdentification236Choice_? Beneficiary { get; init; } 
    /// <summary>
    /// Identification of the third party that administers the transaction.
    /// </summary>
    public OrganisationIdentification15Choice_? TripartyAgent { get; init; } 
    /// <summary>
    /// Identification of the broker involved in the securities lending transaction.
    /// </summary>
    public OrganisationIdentification15Choice_? Broker { get; init; } 
    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    public OrganisationIdentification15Choice_? ClearingMember { get; init; } 
    /// <summary>
    /// Identification of the parties settling the contract on behalf of the deliverer or receiver.
    /// </summary>
    public SettlementParties34Choice_? SettlementParties { get; init; } 
    /// <summary>
    /// Identification of the agent lender involved in the securities lending transaction.
    /// </summary>
    public OrganisationIdentification15Choice_? AgentLender { get; init; } 
    
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
        if (Beneficiary is PartyIdentification236Choice_ BeneficiaryValue)
        {
            writer.WriteStartElement(null, "Bnfcry", xmlNamespace );
            BeneficiaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TripartyAgent is OrganisationIdentification15Choice_ TripartyAgentValue)
        {
            writer.WriteStartElement(null, "TrptyAgt", xmlNamespace );
            TripartyAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Broker is OrganisationIdentification15Choice_ BrokerValue)
        {
            writer.WriteStartElement(null, "Brkr", xmlNamespace );
            BrokerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingMember is OrganisationIdentification15Choice_ ClearingMemberValue)
        {
            writer.WriteStartElement(null, "ClrMmb", xmlNamespace );
            ClearingMemberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementParties is SettlementParties34Choice_ SettlementPartiesValue)
        {
            writer.WriteStartElement(null, "SttlmPties", xmlNamespace );
            SettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AgentLender is OrganisationIdentification15Choice_ AgentLenderValue)
        {
            writer.WriteStartElement(null, "AgtLndr", xmlNamespace );
            AgentLenderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionCounterpartyData11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
