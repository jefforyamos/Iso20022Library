﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BreakdownByParty3.  ISO2002 ID# _LVijGQatEeS3lpTattq7hg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by party.
/// </summary>
public partial record BreakdownByParty3
     : IIsoXmlSerilizable<BreakdownByParty3>
{
    #nullable enable
    
    /// <summary>
    /// Party, for example, fund management company, for which the cash flow is being reported.
    /// </summary>
    public required InvestmentAccount42 Party { get; init; } 
    /// <summary>
    /// Additional parameter/s applied to the cash flow by party.
    /// </summary>
    public AdditionalParameters1? AdditionalParameters { get; init; } 
    /// <summary>
    /// Cash movement into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    public CashInForecast5? CashInForecast { get; init; } 
    /// <summary>
    /// Cash movement out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    public CashOutForecast5? CashOutForecast { get; init; } 
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the party.
    /// </summary>
    public NetCashForecast4? NetCashForecast { get; init; } 
    
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
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalParameters is AdditionalParameters1 AdditionalParametersValue)
        {
            writer.WriteStartElement(null, "AddtlParams", xmlNamespace );
            AdditionalParametersValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashInForecast is CashInForecast5 CashInForecastValue)
        {
            writer.WriteStartElement(null, "CshInFcst", xmlNamespace );
            CashInForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashOutForecast is CashOutForecast5 CashOutForecastValue)
        {
            writer.WriteStartElement(null, "CshOutFcst", xmlNamespace );
            CashOutForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetCashForecast is NetCashForecast4 NetCashForecastValue)
        {
            writer.WriteStartElement(null, "NetCshFcst", xmlNamespace );
            NetCashForecastValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BreakdownByParty3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
