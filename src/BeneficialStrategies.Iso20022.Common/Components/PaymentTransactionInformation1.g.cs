﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionInformation1.  ISO2002 ID# _PsqLS9p-Ed-ak6NoX_4Aeg_-1746248440.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the original transactions, to which the status report message refers.
/// </summary>
public partial record PaymentTransactionInformation1
     : IIsoXmlSerilizable<PaymentTransactionInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reported status.
    /// </summary>
    public IsoMax35Text? StatusIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    public TransactionIndividualStatus1Code? TransactionStatus { get; init; } 
    /// <summary>
    /// Detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation1? StatusReasonInformation { get; init; } 
    /// <summary>
    /// Information on charges related to the processing of the rejection of the instruction.||Usage: ChargesInformation is past on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    public ChargesInformation1? ChargesInformation { get; init; } 
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor's agent in case of a credit transfer, creditor's agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    
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
        if (StatusIdentification is IsoMax35Text StatusIdentificationValue)
        {
            writer.WriteStartElement(null, "StsId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(StatusIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalPaymentInformationIdentification is IsoMax35Text OriginalPaymentInformationIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlPmtInfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalPaymentInformationIdentificationValue)); // data type Max35Text System.String
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
        if (TransactionStatus is TransactionIndividualStatus1Code TransactionStatusValue)
        {
            writer.WriteStartElement(null, "TxSts", xmlNamespace );
            writer.WriteValue(TransactionStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (StatusReasonInformation is StatusReasonInformation1 StatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "StsRsnInf", xmlNamespace );
            StatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargesInformation is ChargesInformation1 ChargesInformationValue)
        {
            writer.WriteStartElement(null, "ChrgsInf", xmlNamespace );
            ChargesInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AcceptanceDateTime is IsoISODateTime AcceptanceDateTimeValue)
        {
            writer.WriteStartElement(null, "AccptncDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(AcceptanceDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (InstructingAgent is BranchAndFinancialInstitutionIdentification3 InstructingAgentValue)
        {
            writer.WriteStartElement(null, "InstgAgt", xmlNamespace );
            InstructingAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructedAgent is BranchAndFinancialInstitutionIdentification3 InstructedAgentValue)
        {
            writer.WriteStartElement(null, "InstdAgt", xmlNamespace );
            InstructedAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference1 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransactionInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
