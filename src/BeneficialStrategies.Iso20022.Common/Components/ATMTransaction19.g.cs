﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction19.  ISO2002 ID# _YM1VAa4PEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the deposit request.
/// </summary>
public partial record ATMTransaction19
     : IIsoXmlSerilizable<ATMTransaction19>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    public FailureReason7Code? Incident { get; init; } 
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    public IsoMax70Text? IncidentDetail { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount8? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Total amount deposed by the customer.
    /// </summary>
    public required AmountAndCurrency1 TotalDepositedAmount { get; init; } 
    /// <summary>
    /// Total authorised amount of the deposit transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAuthorisedAmount { get; init; } 
    /// <summary>
    /// Total requested amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Amounts of the deposit transaction.
    /// </summary>
    public DetailedAmount16? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    public DetailedAmount13? AdditionalCharge { get; init; } 
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    /// <summary>
    /// Outcome of the deposit authorisation.
    /// </summary>
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    /// <summary>
    /// Deposited media put in the safe.
    /// </summary>
    public ATMDepositedMedia1? DepositedMedia { get; init; } 
    /// <summary>
    /// Media unit not put in the safe. These deposits have to be reconciliated.
    /// </summary>
    public ATMDepositedMedia3? ToBeReconciledMediaCounters { get; init; } 
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    public ATMTotals1? ATMTotals { get; init; } 
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    public ATMCassette2? Cassette { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
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
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxSts", xmlNamespace );
        writer.WriteValue(TransactionStatus.ToString()); // Enum value
        writer.WriteEndElement();
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Incident is FailureReason7Code IncidentValue)
        {
            writer.WriteStartElement(null, "Incdnt", xmlNamespace );
            writer.WriteValue(IncidentValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (IncidentDetail is IsoMax70Text IncidentDetailValue)
        {
            writer.WriteStartElement(null, "IncdntDtl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(IncidentDetailValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (AccountData is CardAccount8 AccountDataValue)
        {
            writer.WriteStartElement(null, "AcctData", xmlNamespace );
            AccountDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedAccountData is ContentInformationType10 ProtectedAccountDataValue)
        {
            writer.WriteStartElement(null, "PrtctdAcctData", xmlNamespace );
            ProtectedAccountDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlDpstdAmt", xmlNamespace );
        TotalDepositedAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlAuthrsdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAuthorisedAmount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (TotalRequestedAmount is IsoImpliedCurrencyAndAmount TotalRequestedAmountValue)
        {
            writer.WriteStartElement(null, "TtlReqdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalRequestedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DetailedRequestedAmount is DetailedAmount16 DetailedRequestedAmountValue)
        {
            writer.WriteStartElement(null, "DtldReqdAmt", xmlNamespace );
            DetailedRequestedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalCharge is DetailedAmount13 AdditionalChargeValue)
        {
            writer.WriteStartElement(null, "AddtlChrg", xmlNamespace );
            AdditionalChargeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedReceipt is IsoTrueFalseIndicator RequestedReceiptValue)
        {
            writer.WriteStartElement(null, "ReqdRct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(RequestedReceiptValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (ReceiptPrinted is IsoTrueFalseIndicator ReceiptPrintedValue)
        {
            writer.WriteStartElement(null, "RctPrtd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ReceiptPrintedValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (AuthorisationResult is AuthorisationResult13 AuthorisationResultValue)
        {
            writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
            AuthorisationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DepositedMedia is ATMDepositedMedia1 DepositedMediaValue)
        {
            writer.WriteStartElement(null, "DpstdMdia", xmlNamespace );
            DepositedMediaValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ToBeReconciledMediaCounters is ATMDepositedMedia3 ToBeReconciledMediaCountersValue)
        {
            writer.WriteStartElement(null, "ToBeRcncldMdiaCntrs", xmlNamespace );
            ToBeReconciledMediaCountersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ATMTotals is ATMTotals1 ATMTotalsValue)
        {
            writer.WriteStartElement(null, "ATMTtls", xmlNamespace );
            ATMTotalsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cassette is ATMCassette2 CassetteValue)
        {
            writer.WriteStartElement(null, "Csstt", xmlNamespace );
            CassetteValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static ATMTransaction19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
