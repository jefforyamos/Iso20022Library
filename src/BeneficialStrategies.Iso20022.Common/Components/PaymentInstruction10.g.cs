﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction10.  ISO2002 ID# _7FdFQSHREeKGep4bhmamiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the credit side of the payment transactions included in the direct debit initiation.
/// </summary>
public partial record PaymentInstruction10
     : IIsoXmlSerilizable<PaymentInstruction10>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    public required PaymentMethod2Code PaymentMethod { get; init; } 
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
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    public required IsoISODate RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required PartyIdentification43 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public required CashAccount24 CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount24? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification43? UltimateCreditor { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor's account.
    /// </summary>
    public CashAccount24? ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    public DirectDebitTransactionInformation13? DirectDebitTransactionInformation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _7aKxcSHREeKGep4bhmamiA
    
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
        if (PaymentTypeInformation is PaymentTypeInformation24 PaymentTypeInformationValue)
        {
            writer.WriteStartElement(null, "PmtTpInf", xmlNamespace );
            PaymentTypeInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ReqdColltnDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(RequestedCollectionDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cdtr", xmlNamespace );
        Creditor.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtrAcct", xmlNamespace );
        CreditorAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtrAgt", xmlNamespace );
        CreditorAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CreditorAgentAccount is CashAccount24 CreditorAgentAccountValue)
        {
            writer.WriteStartElement(null, "CdtrAgtAcct", xmlNamespace );
            CreditorAgentAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UltimateCreditor is PartyIdentification43 UltimateCreditorValue)
        {
            writer.WriteStartElement(null, "UltmtCdtr", xmlNamespace );
            UltimateCreditorValue.Serialize(writer, xmlNamespace);
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
        if (CreditorSchemeIdentification is PartyIdentification43 CreditorSchemeIdentificationValue)
        {
            writer.WriteStartElement(null, "CdtrSchmeId", xmlNamespace );
            CreditorSchemeIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize DirectDebitTransactionInformation, multiplicity Unknown
    }
    public static PaymentInstruction10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
