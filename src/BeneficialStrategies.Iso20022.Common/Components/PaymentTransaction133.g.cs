﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction133.  ISO2002 ID# _buMPMdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
public partial record PaymentTransaction133
     : IIsoXmlSerilizable<PaymentTransaction133>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    public IsoMax35Text? ReturnIdentification { get; init; } 
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalClearingSystemReference { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// Usage: the OriginalInterbankSettlementDate is the interbank settlement date of the original instruction return message, and not of the return message.
    /// </summary>
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the type of the return transaction.
    /// </summary>
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    public required IsoActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the return message, and not of the original instruction.
    /// </summary>
    public Priority3Code? SettlementPriority { get; init; } 
    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    public Charges7? ChargesInformation { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the clearing system, to unambiguously identify the return instruction.
    /// </summary>
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    public TransactionParties10? ReturnChain { get; init; } 
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    public PaymentReturnReason6? ReturnReasonInformation { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference36? OriginalTransactionReference { get; init; } 
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
        if (ReturnIdentification is IsoMax35Text ReturnIdentificationValue)
        {
            writer.WriteStartElement(null, "RtrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReturnIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalGroupInformation is OriginalGroupInformation29 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalInstructionIdentification is IsoMax35Text OriginalInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalEndToEndIdentification is IsoMax35Text OriginalEndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlEndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalTransactionIdentification is IsoMax35Text OriginalTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalUETR is IsoUUIDv4Identifier OriginalUETRValue)
        {
            writer.WriteStartElement(null, "OrgnlUETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(OriginalUETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        if (OriginalClearingSystemReference is IsoMax35Text OriginalClearingSystemReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlClrSysRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalClearingSystemReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalInterbankSettlementAmount is IsoActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlIntrBkSttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInterbankSettlementAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OriginalInterbankSettlementDate is IsoISODate OriginalInterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "OrgnlIntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OriginalInterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (PaymentTypeInformation is PaymentTypeInformation28 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RtrdIntrBkSttlmAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ReturnedInterbankSettlementAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (InterbankSettlementDate is IsoISODate InterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "IntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(InterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (SettlementPriority is Priority3Code SettlementPriorityValue)
        {
            writer.WriteStartElement(null, "SttlmPrty", xmlNamespace );
            writer.WriteValue(SettlementPriorityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SettlementTimeIndication is SettlementDateTimeIndication1 SettlementTimeIndicationValue)
        {
            writer.WriteStartElement(null, "SttlmTmIndctn", xmlNamespace );
            SettlementTimeIndicationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementTimeRequest is SettlementTimeRequest2 SettlementTimeRequestValue)
        {
            writer.WriteStartElement(null, "SttlmTmReq", xmlNamespace );
            SettlementTimeRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnedInstructedAmount is IsoActiveOrHistoricCurrencyAndAmount ReturnedInstructedAmountValue)
        {
            writer.WriteStartElement(null, "RtrdInstdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(ReturnedInstructedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ExchangeRate is IsoBaseOneRate ExchangeRateValue)
        {
            writer.WriteStartElement(null, "XchgRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBaseOneRate(ExchangeRateValue)); // data type BaseOneRate System.Decimal
            writer.WriteEndElement();
        }
        if (CompensationAmount is IsoActiveOrHistoricCurrencyAndAmount CompensationAmountValue)
        {
            writer.WriteStartElement(null, "CompstnAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(CompensationAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargesInformation is Charges7 ChargesInformationValue)
        {
            writer.WriteStartElement(null, "ChrgsInf", xmlNamespace );
            ChargesInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClearingSystemReference is IsoMax35Text ClearingSystemReferenceValue)
        {
            writer.WriteStartElement(null, "ClrSysRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClearingSystemReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
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
        if (ReturnChain is TransactionParties10 ReturnChainValue)
        {
            writer.WriteStartElement(null, "RtrChain", xmlNamespace );
            ReturnChainValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnReasonInformation is PaymentReturnReason6 ReturnReasonInformationValue)
        {
            writer.WriteStartElement(null, "RtrRsnInf", xmlNamespace );
            ReturnReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference36 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction133 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
