﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EntryTransaction11.  ISO2002 ID# _bZJMRdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
public partial record EntryTransaction11
     : IIsoXmlSerilizable<EntryTransaction11>
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the underlying transaction.
    /// </summary>
    public TransactionReferences6? References { get; init; } 
    /// <summary>
    /// Amount of money in the cash transaction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Indicates whether the transaction is a credit or a debit transaction.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Provides detailed information on the original amount.||Usage: This component (on transaction level) should be used in case booking is for a single transaction and the original amount is different from the entry amount. It can also be used in case individual original amounts are provided in case of a batch or aggregate booking.
    /// </summary>
    public AmountAndCurrencyExchange3? AmountDetails { get; init; } 
    /// <summary>
    /// Indicates when the booked amount of money will become available, that is can be accessed and starts generating interest. ||Usage: This type of information is used in the US and is linked to particular instruments such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the amount of money will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    public CashAvailability1? Availability { get; init; } 
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    /// <summary>
    /// Provides information on the charges, pre-advised or included in the entry amount.
    /// Usage: This component (on transaction level) can be used in case the booking is for a single transaction, and charges are included in the entry amount. It can also be used in case individual charge amounts are applied to individual transactions in case of a batch or aggregate amount booking.
    /// </summary>
    public Charges6? Charges { get; init; } 
    /// <summary>
    /// Provides details of the interest amount included in the entry amount.||Usage: This component (on transaction level) can be used if the booking is for a single transaction, and interest amount is included in the entry amount. It can also be used if individual interest amounts are applied to individual transactions in the case of a batch or aggregate amount booking.
    /// </summary>
    public TransactionInterest4? Interest { get; init; } 
    /// <summary>
    /// Set of elements used to identify the parties related to the underlying transaction.
    /// </summary>
    public TransactionParties9? RelatedParties { get; init; } 
    /// <summary>
    /// Set of elements used to identify the agents related to the underlying transaction.
    /// </summary>
    public TransactionAgents5? RelatedAgents { get; init; } 
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public ValueList<RemittanceLocation7> RelatedRemittanceInformation { get; init; } = [];
    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    /// <summary>
    /// Set of elements used to identify the dates related to the underlying transactions.
    /// </summary>
    public TransactionDates3? RelatedDates { get; init; } 
    /// <summary>
    /// Set of elements used to identify the price information related to the underlying transaction.
    /// </summary>
    public TransactionPrice4Choice_? RelatedPrice { get; init; } 
    /// <summary>
    /// Set of elements used to identify the related quantities, such as securities, in the underlying transaction.
    /// </summary>
    public TransactionQuantities3Choice_? RelatedQuantities { get; init; } 
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation10? Tax { get; init; } 
    /// <summary>
    /// Provides the return information.
    /// </summary>
    public PaymentReturnReason5? ReturnInformation { get; init; } 
    /// <summary>
    /// Set of elements used to identify the underlying corporate action.
    /// </summary>
    public CorporateAction9? CorporateAction { get; init; } 
    /// <summary>
    /// Safekeeping or investment account. A safekeeping account is an account on which a securities entry is made. An investment account is an account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Provides the details of a cash deposit for an amount of money in cash notes and/or coins.
    /// </summary>
    public CashDeposit1? CashDeposit { get; init; } 
    /// <summary>
    /// Provides the data related to the card (number, scheme), terminal (number, identification) and transactional data used to uniquely identify a card transaction.
    /// </summary>
    public CardTransaction18? CardTransaction { get; init; } 
    /// <summary>
    /// Further details of the transaction.
    /// </summary>
    public IsoMax500Text? AdditionalTransactionInformation { get; init; } 
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
        if (References is TransactionReferences6 ReferencesValue)
        {
            writer.WriteStartElement(null, "Refs", xmlNamespace );
            ReferencesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Amount is IsoActiveOrHistoricCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(AmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CreditDebitIndicator is CreditDebitCode CreditDebitIndicatorValue)
        {
            writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
            writer.WriteValue(CreditDebitIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AmountDetails is AmountAndCurrencyExchange3 AmountDetailsValue)
        {
            writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
            AmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Availability is CashAvailability1 AvailabilityValue)
        {
            writer.WriteStartElement(null, "Avlbty", xmlNamespace );
            AvailabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BankTransactionCode is BankTransactionCodeStructure4 BankTransactionCodeValue)
        {
            writer.WriteStartElement(null, "BkTxCd", xmlNamespace );
            BankTransactionCodeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Charges is Charges6 ChargesValue)
        {
            writer.WriteStartElement(null, "Chrgs", xmlNamespace );
            ChargesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Interest is TransactionInterest4 InterestValue)
        {
            writer.WriteStartElement(null, "Intrst", xmlNamespace );
            InterestValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedParties is TransactionParties9 RelatedPartiesValue)
        {
            writer.WriteStartElement(null, "RltdPties", xmlNamespace );
            RelatedPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedAgents is TransactionAgents5 RelatedAgentsValue)
        {
            writer.WriteStartElement(null, "RltdAgts", xmlNamespace );
            RelatedAgentsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalInstrument is LocalInstrument2Choice_ LocalInstrumentValue)
        {
            writer.WriteStartElement(null, "LclInstrm", xmlNamespace );
            LocalInstrumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Purpose is Purpose2Choice_ PurposeValue)
        {
            writer.WriteStartElement(null, "Purp", xmlNamespace );
            PurposeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RltdRmtInf", xmlNamespace );
        RelatedRemittanceInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RemittanceInformation is RemittanceInformation21 RemittanceInformationValue)
        {
            writer.WriteStartElement(null, "RmtInf", xmlNamespace );
            RemittanceInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedDates is TransactionDates3 RelatedDatesValue)
        {
            writer.WriteStartElement(null, "RltdDts", xmlNamespace );
            RelatedDatesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedPrice is TransactionPrice4Choice_ RelatedPriceValue)
        {
            writer.WriteStartElement(null, "RltdPric", xmlNamespace );
            RelatedPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RelatedQuantities is TransactionQuantities3Choice_ RelatedQuantitiesValue)
        {
            writer.WriteStartElement(null, "RltdQties", xmlNamespace );
            RelatedQuantitiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentIdentification is SecurityIdentification19 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tax is TaxInformation10 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnInformation is PaymentReturnReason5 ReturnInformationValue)
        {
            writer.WriteStartElement(null, "RtrInf", xmlNamespace );
            ReturnInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateAction is CorporateAction9 CorporateActionValue)
        {
            writer.WriteStartElement(null, "CorpActn", xmlNamespace );
            CorporateActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingAccount is SecuritiesAccount19 SafekeepingAccountValue)
        {
            writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
            SafekeepingAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashDeposit is CashDeposit1 CashDepositValue)
        {
            writer.WriteStartElement(null, "CshDpst", xmlNamespace );
            CashDepositValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardTransaction is CardTransaction18 CardTransactionValue)
        {
            writer.WriteStartElement(null, "CardTx", xmlNamespace );
            CardTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalTransactionInformation is IsoMax500Text AdditionalTransactionInformationValue)
        {
            writer.WriteStartElement(null, "AddtlTxInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax500Text(AdditionalTransactionInformationValue)); // data type Max500Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static EntryTransaction11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
