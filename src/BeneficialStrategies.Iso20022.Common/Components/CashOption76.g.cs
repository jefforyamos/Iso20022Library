﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption76.  ISO2002 ID# _fwtL-tseEeqmdMJWobugpw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption76
     : IIsoXmlSerilizable<CashOption76>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Amount of money before any deductions and allowances have been made.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossCashAmount { get; init; } 
    /// <summary>
    /// Amount of money after deductions and allowances have been made, if any, that is, the total amount +/- charges/fees.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetCashAmount { get; init; } 
    /// <summary>
    /// Cash amount based on the terms of the corporate action event and balance of underlying securities, entitled to/from account owner (which may be positive or negative).
    /// </summary>
    public IsoActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public RateAndAmountFormat40Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Amount of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IsoActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 
    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public DateAndDateTime2Choice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    public required DateFormat43Choice_ PaymentDate { get; init; } 
    
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
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (CashAccountIdentification is CashAccountIdentification5Choice_ CashAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
            CashAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GrossCashAmount is IsoActiveCurrencyAndAmount GrossCashAmountValue)
        {
            writer.WriteStartElement(null, "GrssCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(GrossCashAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (NetCashAmount is IsoActiveCurrencyAndAmount NetCashAmountValue)
        {
            writer.WriteStartElement(null, "NetCshAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(NetCashAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EntitledAmount is IsoActiveCurrencyAndAmount EntitledAmountValue)
        {
            writer.WriteStartElement(null, "EntitldAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(EntitledAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (WithholdingTaxRate is RateAndAmountFormat40Choice_ WithholdingTaxRateValue)
        {
            writer.WriteStartElement(null, "WhldgTaxRate", xmlNamespace );
            WithholdingTaxRateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (WithholdingTaxAmount is IsoActiveCurrencyAndAmount WithholdingTaxAmountValue)
        {
            writer.WriteStartElement(null, "WhldgTaxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(WithholdingTaxAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (EarliestPaymentDate is DateAndDateTime2Choice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PmtDt", xmlNamespace );
        PaymentDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CashOption76 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
