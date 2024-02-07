﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader49.  ISO2002 ID# _s4rLAlkyEeGeoaLUQk__nA_-650190179.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
public partial record GroupHeader49
     : IIsoXmlSerilizable<GroupHeader49>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    public required IsoMax15NumericText NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    public required SettlementInstruction1 SettlementInformation { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    
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
        writer.WriteStartElement(null, "MsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CreDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(CreationDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (BatchBooking is IsoBatchBookingIndicator BatchBookingValue)
        {
            writer.WriteStartElement(null, "BtchBookg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBatchBookingIndicator(BatchBookingValue)); // data type BatchBookingIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NbOfTxs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15NumericText(NumberOfTransactions)); // data type Max15NumericText System.String
        writer.WriteEndElement();
        if (ControlSum is IsoDecimalNumber ControlSumValue)
        {
            writer.WriteStartElement(null, "CtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (TotalInterbankSettlementAmount is IsoActiveCurrencyAndAmount TotalInterbankSettlementAmountValue)
        {
            writer.WriteStartElement(null, "TtlIntrBkSttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalInterbankSettlementAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InterbankSettlementDate is IsoISODate InterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmInf", xmlNamespace );
        SettlementInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentTypeInformation is PaymentTypeInformation21 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructingAgent is BranchAndFinancialInstitutionIdentification5 InstructingAgentValue)
        {
            writer.WriteStartElement(null, "InstgAgt", xmlNamespace );
            InstructingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedAgent is BranchAndFinancialInstitutionIdentification5 InstructedAgentValue)
        {
            writer.WriteStartElement(null, "InstdAgt", xmlNamespace );
            InstructedAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GroupHeader49 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
