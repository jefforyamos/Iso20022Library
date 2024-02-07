﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails9.  ISO2002 ID# _M46EoS8LEeKW5usMQLtzqw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation inside a batch transfer.
/// </summary>
public partial record CardPaymentTransactionDetails9
     : IIsoXmlSerilizable<CardPaymentTransactionDetails9>
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
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
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
        if (ValidityDate is IsoISODate ValidityDateValue)
        {
            writer.WriteStartElement(null, "VldtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValidityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransactionDetails9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
