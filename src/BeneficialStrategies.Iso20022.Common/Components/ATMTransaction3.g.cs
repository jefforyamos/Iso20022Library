﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction3.  ISO2002 ID# _UGw1MYqQEeSRT5rEzcAHEw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which the completion is sent.
/// </summary>
public partial record ATMTransaction3
     : IIsoXmlSerilizable<ATMTransaction3>
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
    /// Multi bundle dispense.
    /// </summary>
    public IsoTrueFalseIndicator? MultiBundle { get; init; } 
    /// <summary>
    /// Amount per bundle in the currency of the total presented amount, in the order of the presentation.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? BundlePresentedAmount { get; init; } 
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// </summary>
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    public FailureReason4Code? Incident { get; init; } 
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    public IsoMax70Text? IncidentDetail { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount5? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Total amount presented to the customer.
    /// </summary>
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
    /// <summary>
    /// Total requested amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    public CurrencyConversion4? CurrencyConversion { get; init; } 
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
    /// True when the card was captured by the ATM.
    /// </summary>
    public IsoTrueFalseIndicator? CapturedCard { get; init; } 
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    public ATMTransactionAmounts2? Limits { get; init; } 
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    public AuthorisationResult9? AuthorisationResult { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    public ATMTotals1? ATMTotals { get; init; } 
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    public ATMCassette1? Cassette { get; init; } 
    
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
        if (MultiBundle is IsoTrueFalseIndicator MultiBundleValue)
        {
            writer.WriteStartElement(null, "MultiBndl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(MultiBundleValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (BundlePresentedAmount is IsoImpliedCurrencyAndAmount BundlePresentedAmountValue)
        {
            writer.WriteStartElement(null, "BndlPresntdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(BundlePresentedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PresntdAmtSts", xmlNamespace );
        writer.WriteValue(PresentedAmountStatus.ToString()); // Enum value
        writer.WriteEndElement();
        if (Incident is FailureReason4Code IncidentValue)
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
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountData is CardAccount5 AccountDataValue)
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
        writer.WriteStartElement(null, "TtlPresntdAmt", xmlNamespace );
        TotalPresentedAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalAuthorisedAmount is IsoImpliedCurrencyAndAmount TotalAuthorisedAmountValue)
        {
            writer.WriteStartElement(null, "TtlAuthrsdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAuthorisedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalRequestedAmount is IsoImpliedCurrencyAndAmount TotalRequestedAmountValue)
        {
            writer.WriteStartElement(null, "TtlReqdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalRequestedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DetailedRequestedAmount is DetailedAmount12 DetailedRequestedAmountValue)
        {
            writer.WriteStartElement(null, "DtldReqdAmt", xmlNamespace );
            DetailedRequestedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrencyConversion is CurrencyConversion4 CurrencyConversionValue)
        {
            writer.WriteStartElement(null, "CcyConvs", xmlNamespace );
            CurrencyConversionValue.Serialize(writer, xmlNamespace);
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
        if (CapturedCard is IsoTrueFalseIndicator CapturedCardValue)
        {
            writer.WriteStartElement(null, "CaptrdCard", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(CapturedCardValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (Limits is ATMTransactionAmounts2 LimitsValue)
        {
            writer.WriteStartElement(null, "Lmts", xmlNamespace );
            LimitsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AuthorisationResult is AuthorisationResult9 AuthorisationResultValue)
        {
            writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
            AuthorisationResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (ATMTotals is ATMTotals1 ATMTotalsValue)
        {
            writer.WriteStartElement(null, "ATMTtls", xmlNamespace );
            ATMTotalsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Cassette is ATMCassette1 CassetteValue)
        {
            writer.WriteStartElement(null, "Csstt", xmlNamespace );
            CassetteValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMTransaction3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
