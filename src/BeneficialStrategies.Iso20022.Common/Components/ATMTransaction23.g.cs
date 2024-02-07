﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction23.  ISO2002 ID# _t-Wk8a4tEeWLdt0vLARX2Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer information for the transaction.
/// </summary>
public partial record ATMTransaction23
     : IIsoXmlSerilizable<ATMTransaction23>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Description of the transfer for the creditor.
    /// </summary>
    public IsoMax35Text? CreditorLabel { get; init; } 
    /// <summary>
    /// Description of the transfer for the debtor.
    /// </summary>
    public IsoMax35Text? DebtorLabel { get; init; } 
    /// <summary>
    /// Reference of the payment.
    /// </summary>
    public IsoMax35Text? PaymentReference { get; init; } 
    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    public CardAccount7? AccountFrom { get; init; } 
    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountFrom { get; init; } 
    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    public CardAccount7? AccountTo { get; init; } 
    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountTo { get; init; } 
    /// <summary>
    /// Amount of the transaction to be authorised.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    public DetailedAmount17? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    public IsoISODate? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    public IsoMax35Text? InstantTransferProgram { get; init; } 
    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    public RecurringTransaction3? RecurringTransfer { get; init; } 
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
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
        if (ReconciliationIdentification is IsoMax35Text ReconciliationIdentificationValue)
        {
            writer.WriteStartElement(null, "RcncltnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReconciliationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CreditorLabel is IsoMax35Text CreditorLabelValue)
        {
            writer.WriteStartElement(null, "CdtrLabl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CreditorLabelValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DebtorLabel is IsoMax35Text DebtorLabelValue)
        {
            writer.WriteStartElement(null, "DbtrLabl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DebtorLabelValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PaymentReference is IsoMax35Text PaymentReferenceValue)
        {
            writer.WriteStartElement(null, "PmtRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountFrom is CardAccount7 AccountFromValue)
        {
            writer.WriteStartElement(null, "AcctFr", xmlNamespace );
            AccountFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedAccountFrom is ContentInformationType10 ProtectedAccountFromValue)
        {
            writer.WriteStartElement(null, "PrtctdAcctFr", xmlNamespace );
            ProtectedAccountFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountTo is CardAccount7 AccountToValue)
        {
            writer.WriteStartElement(null, "AcctTo", xmlNamespace );
            AccountToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedAccountTo is ContentInformationType10 ProtectedAccountToValue)
        {
            writer.WriteStartElement(null, "PrtctdAcctTo", xmlNamespace );
            ProtectedAccountToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalRequestedAmount is IsoImpliedCurrencyAndAmount TotalRequestedAmountValue)
        {
            writer.WriteStartElement(null, "TtlReqdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalRequestedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (DetailedRequestedAmount is DetailedAmount17 DetailedRequestedAmountValue)
        {
            writer.WriteStartElement(null, "DtldReqdAmt", xmlNamespace );
            DetailedRequestedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedExecutionDate is IsoISODate RequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RequestedExecutionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (InstantTransferProgram is IsoMax35Text InstantTransferProgramValue)
        {
            writer.WriteStartElement(null, "InstntTrfPrgm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InstantTransferProgramValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (RecurringTransfer is RecurringTransaction3 RecurringTransferValue)
        {
            writer.WriteStartElement(null, "RcrngTrf", xmlNamespace );
            RecurringTransferValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedReceipt is IsoTrueFalseIndicator RequestedReceiptValue)
        {
            writer.WriteStartElement(null, "ReqdRct", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(RequestedReceiptValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static ATMTransaction23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
