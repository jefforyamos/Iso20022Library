﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvoiceTotals1.  ISO2002 ID# _Tho4zNp-Ed-ak6NoX_4Aeg_-773420460.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies totals related to the invoice.
/// </summary>
public partial record InvoiceTotals1
     : IIsoXmlSerilizable<InvoiceTotals1>
{
    #nullable enable
    
    /// <summary>
    /// Total amount subject to tax.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalTaxableAmount { get; init; } 
    /// <summary>
    /// Sum of all tax amounts related to the invoice.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalTaxAmount { get; init; } 
    /// <summary>
    /// Variance on invoice amount taking into account discounts, allowances and charges.
    /// </summary>
    public Adjustment5? Adjustment { get; init; } 
    /// <summary>
    /// Total amount of the invoice, being the sum of total invoice lines amounts, total invoice adjustment amount (discounts, allowances and charges) and total tax amounts.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalInvoiceAmount { get; init; } 
    /// <summary>
    /// Due date for the payment of the invoice.
    /// </summary>
    public required IsoISODate PaymentDueDate { get; init; } 
    
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
        writer.WriteStartElement(null, "TtlTaxblAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalTaxableAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TtlTaxAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalTaxAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (Adjustment is Adjustment5 AdjustmentValue)
        {
            writer.WriteStartElement(null, "Adjstmnt", xmlNamespace );
            AdjustmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlInvcAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalInvoiceAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtDueDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(PaymentDueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static InvoiceTotals1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
