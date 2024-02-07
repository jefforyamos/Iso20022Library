﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LodgingLineItem2.  ISO2002 ID# _Z6ldASCDEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging line item details
/// </summary>
public partial record LodgingLineItem2
     : IIsoXmlSerilizable<LodgingLineItem2>
{
    #nullable enable
    
    /// <summary>
    /// Date of the charge for the product or service associated with the line item. 
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Time of the charge for the product or service associated with the line item. 
    /// </summary>
    public IsoISOTime? Time { get; init; } 
    /// <summary>
    /// Type of product or service associated with the line item. 
    /// </summary>
    public LodgingService1Code? Type { get; init; } 
    /// <summary>
    /// Other type of product or service associated with the line item. 
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Indicates whether or not the charge originated following the checkout. 
    /// </summary>
    public IsoTrueFalseIndicator? PostCheckOutIndicator { get; init; } 
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    public CreditDebit3Code? CreditDebit { get; init; } 
    /// <summary>
    /// Contains the cost for one unit of the product or service.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? UnitAmount { get; init; } 
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    public IsoMax4NumericText? Duration { get; init; } 
    /// <summary>
    /// Subtotal amount of line item.  (e.g. total nightly rate, etc.)
    /// </summary>
    public IsoImpliedCurrencyAndAmount? SubTotalAmount { get; init; } 
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    public Tax39? Tax { get; init; } 
    /// <summary>
    /// Additional data.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
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
        if (Date is IsoISODate DateValue)
        {
            writer.WriteStartElement(null, "Dt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Time is IsoISOTime TimeValue)
        {
            writer.WriteStartElement(null, "Tm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISOTime(TimeValue)); // data type ISOTime System.TimeOnly
            writer.WriteEndElement();
        }
        if (Type is LodgingService1Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherType is IsoMax35Text OtherTypeValue)
        {
            writer.WriteStartElement(null, "OthrTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PostCheckOutIndicator is IsoTrueFalseIndicator PostCheckOutIndicatorValue)
        {
            writer.WriteStartElement(null, "PstChckOutInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(PostCheckOutIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CreditDebit is CreditDebit3Code CreditDebitValue)
        {
            writer.WriteStartElement(null, "CdtDbt", xmlNamespace );
            writer.WriteValue(CreditDebitValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UnitAmount is IsoImpliedCurrencyAndAmount UnitAmountValue)
        {
            writer.WriteStartElement(null, "UnitAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(UnitAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Duration is IsoMax4NumericText DurationValue)
        {
            writer.WriteStartElement(null, "Drtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4NumericText(DurationValue)); // data type Max4NumericText System.String
            writer.WriteEndElement();
        }
        if (SubTotalAmount is IsoImpliedCurrencyAndAmount SubTotalAmountValue)
        {
            writer.WriteStartElement(null, "SubTtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(SubTotalAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Tax is Tax39 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalData is IsoMax350Text AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalDataValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static LodgingLineItem2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
