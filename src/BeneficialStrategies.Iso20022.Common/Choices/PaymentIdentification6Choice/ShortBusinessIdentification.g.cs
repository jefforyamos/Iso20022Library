﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ShortBusinessIdentification.  ISO2002 ID# _Aghbl24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification6Choice;

/// <summary>
/// Business identification of the payment instruction given by the clearing agent.
/// </summary>
public partial record ShortBusinessIdentification : PaymentIdentification6Choice_
     , IIsoXmlSerilizable<ShortBusinessIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public required IsoISODate InterBankSettlementDate { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(InterBankSettlementDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstgAgt", xmlNamespace );
        InstructingAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static new ShortBusinessIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
