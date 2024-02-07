﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails32.  ISO2002 ID# _gyI7MY3UEeWjkqXgn_0Imw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation response contained in a batch.
/// </summary>
public partial record CardPaymentTransactionDetails32
     : IIsoXmlSerilizable<CardPaymentTransactionDetails32>
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
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    public DetailedAmount15? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public CardAccountType3Code? AccountType { get; init; } 
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
        if (DetailedAmount is DetailedAmount15 DetailedAmountValue)
        {
            writer.WriteStartElement(null, "DtldAmt", xmlNamespace );
            DetailedAmountValue.Serialize(writer, xmlNamespace);
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
        if (AccountType is CardAccountType3Code AccountTypeValue)
        {
            writer.WriteStartElement(null, "AcctTp", xmlNamespace );
            writer.WriteValue(AccountTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransactionDetails32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
