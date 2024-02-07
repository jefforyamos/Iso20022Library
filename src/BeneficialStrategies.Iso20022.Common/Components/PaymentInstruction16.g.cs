﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction16.  ISO2002 ID# _euj3ER77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the debit side of the payment transactions included in the credit transfer initiation.
/// </summary>
public partial record PaymentInstruction16
     : IIsoXmlSerilizable<PaymentInstruction16>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    public required PaymentMethod3Code PaymentMethod { get; init; } 
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public required IsoISODate RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification43 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public required CashAccount24 DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// Usage: when present, then the instructions for the debtor agent apply for all credit transfer transaction information occurrences, present in the payment information.
    /// </summary>
    public IsoMax140Text? InstructionForDebtorAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification43? UltimateDebtor { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor's account.
    /// </summary>
    public CashAccount24? ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the debtor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; } 
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    public CreditTransferTransaction20? CreditTransferTransactionInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _e_6s9x77EeSxevWRRWxNAg
    
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
        writer.WriteStartElement(null, "PmtInfId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentInformationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtMtd", xmlNamespace );
        writer.WriteValue(PaymentMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (BatchBooking is IsoBatchBookingIndicator BatchBookingValue)
        {
            writer.WriteStartElement(null, "BtchBookg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBatchBookingIndicator(BatchBookingValue)); // data type BatchBookingIndicator System.String
            writer.WriteEndElement();
        }
        if (NumberOfTransactions is IsoMax15NumericText NumberOfTransactionsValue)
        {
            writer.WriteStartElement(null, "NbOfTxs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(NumberOfTransactionsValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (ControlSum is IsoDecimalNumber ControlSumValue)
        {
            writer.WriteStartElement(null, "CtrlSum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(ControlSumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (PaymentTypeInformation is PaymentTypeInformation19 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(RequestedExecutionDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (PoolingAdjustmentDate is IsoISODate PoolingAdjustmentDateValue)
        {
            writer.WriteStartElement(null, "PoolgAdjstmntDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(PoolingAdjustmentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Dbtr", xmlNamespace );
        Debtor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DbtrAcct", xmlNamespace );
        DebtorAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DbtrAgt", xmlNamespace );
        DebtorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DebtorAgentAccount is CashAccount24 DebtorAgentAccountValue)
        {
            writer.WriteStartElement(null, "DbtrAgtAcct", xmlNamespace );
            DebtorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionForDebtorAgent is IsoMax140Text InstructionForDebtorAgentValue)
        {
            writer.WriteStartElement(null, "InstrForDbtrAgt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(InstructionForDebtorAgentValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (UltimateDebtor is PartyIdentification43 UltimateDebtorValue)
        {
            writer.WriteStartElement(null, "UltmtDbtr", xmlNamespace );
            UltimateDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargesAccount is CashAccount24 ChargesAccountValue)
        {
            writer.WriteStartElement(null, "ChrgsAcct", xmlNamespace );
            ChargesAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesAccountAgent is BranchAndFinancialInstitutionIdentification5 ChargesAccountAgentValue)
        {
            writer.WriteStartElement(null, "ChrgsAcctAgt", xmlNamespace );
            ChargesAccountAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize CreditTransferTransactionInformation, multiplicity Unknown
    }
    public static PaymentInstruction16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
