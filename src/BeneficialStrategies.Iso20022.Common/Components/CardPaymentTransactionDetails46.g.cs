﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails46.  ISO2002 ID# _5L_mkfazEeerBJ4shjAzSA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the payment transaction.
/// </summary>
public partial record CardPaymentTransactionDetails46
     : IIsoXmlSerilizable<CardPaymentTransactionDetails46>
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    public DetailedAmount15? DetailedAmount { get; init; } 
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
        writer.WriteStartElement(null, "Ccy", xmlNamespace );
        writer.WriteValue(Currency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(TotalAmount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
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
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransactionDetails46 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
