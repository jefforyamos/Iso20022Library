﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount7.  ISO2002 ID# _ddRJ8WkEEeS7zPBpvm732w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
public partial record DetailedAmount7
     : IIsoXmlSerilizable<DetailedAmount7>
{
    #nullable enable
    
    /// <summary>
    /// Cash-back amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CashBack { get; init; } 
    /// <summary>
    /// Gratuity amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? Gratuity { get; init; } 
    /// <summary>
    /// Fees amount.
    /// </summary>
    public DetailedAmount4? Fees { get; init; } 
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// </summary>
    public DetailedAmount4? Rebate { get; init; } 
    /// <summary>
    /// Value added tax amount.
    /// </summary>
    public DetailedAmount4? ValueAddedTax { get; init; } 
    /// <summary>
    /// Additional charge paid by the cardholder. For example airline credit card surcharge.
    /// </summary>
    public DetailedAmount4? Surcharge { get; init; } 
    
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
        if (CashBack is IsoImpliedCurrencyAndAmount CashBackValue)
        {
            writer.WriteStartElement(null, "CshBck", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(CashBackValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Gratuity is IsoImpliedCurrencyAndAmount GratuityValue)
        {
            writer.WriteStartElement(null, "Grtty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(GratuityValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Fees is DetailedAmount4 FeesValue)
        {
            writer.WriteStartElement(null, "Fees", xmlNamespace );
            FeesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Rebate is DetailedAmount4 RebateValue)
        {
            writer.WriteStartElement(null, "Rbt", xmlNamespace );
            RebateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueAddedTax is DetailedAmount4 ValueAddedTaxValue)
        {
            writer.WriteStartElement(null, "ValAddedTax", xmlNamespace );
            ValueAddedTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Surcharge is DetailedAmount4 SurchargeValue)
        {
            writer.WriteStartElement(null, "Srchrg", xmlNamespace );
            SurchargeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DetailedAmount7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
