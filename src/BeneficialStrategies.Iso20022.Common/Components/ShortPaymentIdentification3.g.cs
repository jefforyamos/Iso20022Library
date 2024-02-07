﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ShortPaymentIdentification3.  ISO2002 ID# _pgahQAKyEe2X55dNQNVKfg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a payment instruction by a simple set of characteristics which provides an unambiguous identification of the instruction.
/// </summary>
public partial record ShortPaymentIdentification3
     : IIsoXmlSerilizable<ShortPaymentIdentification3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public required IsoISODate InterbankSettlementDate { get; init; } 
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (TransactionIdentification is IsoMax35Text TransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UETR is IsoUUIDv4Identifier UETRValue)
        {
            writer.WriteStartElement(null, "UETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(UETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(InterbankSettlementDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstgAgt", xmlNamespace );
        InstructingAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ShortPaymentIdentification3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
