﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BreakdownByCountry1.  ISO2002 ID# _RQDQptp-Ed-ak6NoX_4Aeg_1416516304.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by country.
/// </summary>
public partial record BreakdownByCountry1
     : IIsoXmlSerilizable<BreakdownByCountry1>
{
    #nullable enable
    
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    public required CountryCode Country { get; init; } 
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    public CashInForecast3? CashInForecast { get; init; } 
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    public CashOutForecast3? CashOutForecast { get; init; } 
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the country.
    /// </summary>
    public NetCashForecast2? NetCashForecast { get; init; } 
    
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
        writer.WriteStartElement(null, "Ctry", xmlNamespace );
        writer.WriteValue(Country.ToString()); // Enum value
        writer.WriteEndElement();
        if (CashInForecast is CashInForecast3 CashInForecastValue)
        {
            writer.WriteStartElement(null, "CshInFcst", xmlNamespace );
            CashInForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashOutForecast is CashOutForecast3 CashOutForecastValue)
        {
            writer.WriteStartElement(null, "CshOutFcst", xmlNamespace );
            CashOutForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetCashForecast is NetCashForecast2 NetCashForecastValue)
        {
            writer.WriteStartElement(null, "NetCshFcst", xmlNamespace );
            NetCashForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BreakdownByCountry1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
