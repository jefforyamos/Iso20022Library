﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails51.  ISO2002 ID# _VQERgU3cEey_VecAUE-C9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation request in a batch.
/// </summary>
public partial record CardPaymentTransactionDetails51
     : IIsoXmlSerilizable<CardPaymentTransactionDetails51>
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Contains the updated amount of all authorisations related to the same business transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CumulativeAmount { get; init; } 
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    public DetailedAmount15? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    public OnLineReason2Code? OnLineReason { get; init; } 
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public CardAccountType3Code? AccountType { get; init; } 
    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    public CurrencyConversion24? CurrencyConversionResult { get; init; } 
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    public RecurringTransaction4? Instalment { get; init; } 
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    public AggregationTransaction3? AggregationTransaction { get; init; } 
    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product6? SaleItem { get; init; } 
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    public IsoMax35Text? DeliveryLocation { get; init; } 
    /// <summary>
    /// In case a message is sent after the consumption of goods or service, it indicates the number of times the authorisation has been sent to the Acquirer in order to get an approval.
    /// </summary>
    public IsoPositiveNumber? ReSubmissionCounter { get; init; } 
    /// <summary>
    /// Additional information related to the transaction like an Invoice or IndustryData (for example  hospitality, lodging, transportation).
    /// </summary>
    public ExternallyDefinedData3? AdditionalInformation { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application.
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
        if (Currency is ActiveCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAmount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (CumulativeAmount is IsoImpliedCurrencyAndAmount CumulativeAmountValue)
        {
            writer.WriteStartElement(null, "CmltvAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(CumulativeAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AmountQualifier is TypeOfAmount8Code AmountQualifierValue)
        {
            writer.WriteStartElement(null, "AmtQlfr", xmlNamespace );
            writer.WriteValue(AmountQualifierValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DetailedAmount is DetailedAmount15 DetailedAmountValue)
        {
            writer.WriteStartElement(null, "DtldAmt", xmlNamespace );
            DetailedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestedAmount is IsoImpliedCurrencyAndAmount RequestedAmountValue)
        {
            writer.WriteStartElement(null, "ReqdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(RequestedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AuthorisedAmount is IsoImpliedCurrencyAndAmount AuthorisedAmountValue)
        {
            writer.WriteStartElement(null, "AuthrsdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(AuthorisedAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InvoiceAmount is IsoImpliedCurrencyAndAmount InvoiceAmountValue)
        {
            writer.WriteStartElement(null, "InvcAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(InvoiceAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ValidityDate is IsoISODate ValidityDateValue)
        {
            writer.WriteStartElement(null, "VldtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (OnLineReason is OnLineReason2Code OnLineReasonValue)
        {
            writer.WriteStartElement(null, "OnLineRsn", xmlNamespace );
            writer.WriteValue(OnLineReasonValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UnattendedLevelCategory is IsoMax35NumericText UnattendedLevelCategoryValue)
        {
            writer.WriteStartElement(null, "UattnddLvlCtgy", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35NumericText(UnattendedLevelCategoryValue)); // data type Max35NumericText System.String
            writer.WriteEndElement();
        }
        if (AccountType is CardAccountType3Code AccountTypeValue)
        {
            writer.WriteStartElement(null, "AcctTp", xmlNamespace );
            writer.WriteValue(AccountTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrencyConversionResult is CurrencyConversion24 CurrencyConversionResultValue)
        {
            writer.WriteStartElement(null, "CcyConvsRslt", xmlNamespace );
            CurrencyConversionResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Instalment is RecurringTransaction4 InstalmentValue)
        {
            writer.WriteStartElement(null, "Instlmt", xmlNamespace );
            InstalmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AggregationTransaction is AggregationTransaction3 AggregationTransactionValue)
        {
            writer.WriteStartElement(null, "AggtnTx", xmlNamespace );
            AggregationTransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProductCodeSetIdentification is IsoMax10Text ProductCodeSetIdentificationValue)
        {
            writer.WriteStartElement(null, "PdctCdSetId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10Text(ProductCodeSetIdentificationValue)); // data type Max10Text System.String
            writer.WriteEndElement();
        }
        if (SaleItem is Product6 SaleItemValue)
        {
            writer.WriteStartElement(null, "SaleItm", xmlNamespace );
            SaleItemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveryLocation is IsoMax35Text DeliveryLocationValue)
        {
            writer.WriteStartElement(null, "DlvryLctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DeliveryLocationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReSubmissionCounter is IsoPositiveNumber ReSubmissionCounterValue)
        {
            writer.WriteStartElement(null, "ReSubmissnCntr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPositiveNumber(ReSubmissionCounterValue)); // data type PositiveNumber System.UInt64
            writer.WriteEndElement();
        }
        if (AdditionalInformation is ExternallyDefinedData3 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransactionDetails51 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
