﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DirectDebitTransactionInformation15.  ISO2002 ID# _F4y_SGcKEeKAGeP1fbluEg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual direct debit transaction(s) included in the message.
/// </summary>
public partial record DirectDebitTransactionInformation15
     : IIsoXmlSerilizable<DirectDebitTransactionInformation15>
{
    #nullable enable
    
    /// <summary>
    /// References used for a payment instruction.
    /// </summary>
    public required PaymentIdentification3 PaymentIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of transaction.
    /// </summary>
    public PaymentTypeInformation21? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public required IsoActiveCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    public Priority3Code? SettlementPriority { get; init; } 
    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? UltimateDebtor { get; init; } 
    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount24? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// </summary>
    public IsoMax210Text? InstructionForDebtorAgent { get; init; } 
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation2? RemittanceInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "PmtId", xmlNamespace );
        PaymentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentTypeInformation is PaymentTypeInformation21 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IntrBkSttlmAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(InterbankSettlementAmount)); // data type ActiveCurrencyAndAmount System.Decimal
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
        if (SettlementTimeRequest is SettlementTimeRequest2 SettlementTimeRequestValue)
        {
            writer.WriteStartElement(null, "SttlmTmReq", xmlNamespace );
            SettlementTimeRequestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateDebtor is BranchAndFinancialInstitutionIdentification5 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Dbtr", xmlNamespace );
        Debtor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorAccount is CashAccount24 DebtorAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
            DebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgent is BranchAndFinancialInstitutionIdentification5 DebtorAgentValue)
        {
            writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
            DebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DebtorAgentAccount is CashAccount24 DebtorAgentAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAgtAcct", xmlNamespace );
            DebtorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForDebtorAgent is IsoMax210Text InstructionForDebtorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForDbtrAgt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax210Text(InstructionForDebtorAgentValue)); // data type Max210Text System.String
            writer.WriteEndElement();
        }
        if (RemittanceInformation is RemittanceInformation2 RemittanceInformationValue)
        {
            writer.WriteStartElement(null, "RmtInf", xmlNamespace );
            RemittanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DirectDebitTransactionInformation15 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
