﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionInformation2.  ISO2002 ID# _bgNQUU7dEeifNrXGwadPmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about cumulative subscriptions.
/// </summary>
public partial record SubscriptionInformation2
     : IIsoXmlSerilizable<SubscriptionInformation2>
{
    #nullable enable
    
    /// <summary>
    /// Date of the first subscription in the current year.
    /// </summary>
    public required IsoISODate DateOfFirstSubscription { get; init; } 
    /// <summary>
    /// Amount subscribed in the current tax year into equities (not including dividends).
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? EquityComponent { get; init; } 
    /// <summary>
    /// Amount subscribed in the current tax year into cash.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? CashComponent { get; init; } 
    /// <summary>
    /// Total amount subscribed in the current tax year.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; init; } 
    
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
        writer.WriteStartElement(null, "DtOfFrstSbcpt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(DateOfFirstSubscription)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (EquityComponent is IsoActiveCurrencyAnd13DecimalAmount EquityComponentValue)
        {
            writer.WriteStartElement(null, "EqtyCmpnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(EquityComponentValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CashComponent is IsoActiveCurrencyAnd13DecimalAmount CashComponentValue)
        {
            writer.WriteStartElement(null, "CshCmpnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(CashComponentValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlAmtYrToDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(TotalAmountYearToDate)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
    }
    public static SubscriptionInformation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
