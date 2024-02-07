﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails31.  ISO2002 ID# _u-BdAY3SEeWjkqXgn_0Imw.
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
public partial record CardPaymentTransactionDetails31
     : IIsoXmlSerilizable<CardPaymentTransactionDetails31>
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public CurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    public DetailedAmount15? DetailedAmount { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    public OnLineReason1Code? OnLineReason { get; init; } 
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
    public CurrencyConversion8? CurrencyConversionResult { get; init; } 
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    public RecurringTransaction2? Instalment { get; init; } 
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    public AggregationTransaction2? AggregationTransaction { get; init; } 
    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    public Product3? SaleItem { get; init; } 
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    public IsoMax10Text? DeliveryLocation { get; init; } 
    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    public CardPaymentInvoice2? CardPaymentInvoice { get; init; } 
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
        if (Currency is CurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAmount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (AmountQualifier is TypeOfAmount1Code AmountQualifierValue)
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
        if (ValidityDate is IsoISODate ValidityDateValue)
        {
            writer.WriteStartElement(null, "VldtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (OnLineReason is OnLineReason1Code OnLineReasonValue)
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
        if (CurrencyConversionResult is CurrencyConversion8 CurrencyConversionResultValue)
        {
            writer.WriteStartElement(null, "CcyConvsRslt", xmlNamespace );
            CurrencyConversionResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Instalment is RecurringTransaction2 InstalmentValue)
        {
            writer.WriteStartElement(null, "Instlmt", xmlNamespace );
            InstalmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AggregationTransaction is AggregationTransaction2 AggregationTransactionValue)
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
        if (SaleItem is Product3 SaleItemValue)
        {
            writer.WriteStartElement(null, "SaleItm", xmlNamespace );
            SaleItemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveryLocation is IsoMax10Text DeliveryLocationValue)
        {
            writer.WriteStartElement(null, "DlvryLctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10Text(DeliveryLocationValue)); // data type Max10Text System.String
            writer.WriteEndElement();
        }
        if (CardPaymentInvoice is CardPaymentInvoice2 CardPaymentInvoiceValue)
        {
            writer.WriteStartElement(null, "CardPmtInvc", xmlNamespace );
            CardPaymentInvoiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransactionDetails31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
