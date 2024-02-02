﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForecastParameter1.  ISO2002 ID# _UwUSYdp-Ed-ak6NoX_4Aeg_-550549340.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters used to report cash movements,eg, country code, currency code, BIC or a user defined parameter.
/// </summary>
[DataContract]
[XmlType]
public partial record ForecastParameter1
{
    #nullable enable
    
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    [DataMember]
    public required ReportParameter2Choice_ ReportParameter { get; init; } 
    /// <summary>
    /// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [DataMember]
    public ValueList<CashInForecast1> EstimatedCashInForecastDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [DataMember]
    public ValueList<CashOutForecast1> EstimatedCashOutForecastDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [DataMember]
    public ValueList<NetCashForecast1> EstimatedNetCashForecastDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
