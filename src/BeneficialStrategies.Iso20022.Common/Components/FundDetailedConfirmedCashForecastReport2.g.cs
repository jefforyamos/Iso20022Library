﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundDetailedConfirmedCashForecastReport2.  ISO2002 ID# _RPmku9p-Ed-ak6NoX_4Aeg_-256800213.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a cash forecast report.
/// </summary>
[DataContract]
[XmlType]
public partial record FundDetailedConfirmedCashForecastReport2
{
    #nullable enable
    
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [DataMember]
    public ValueList<FundCashForecast4> FundCashForecastDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [DataMember]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<Extension1> Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
