﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForecastParameter2.  ISO2002 ID# _UuOnttp-Ed-ak6NoX_4Aeg_215969786.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters used to report cash movements,eg, country code, currency code, BIC or a user defined parameter.
/// </summary>
public partial record ForecastParameter2
{
    #nullable enable
    
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    public required IReportParameter2Choice ReportParameter { get; init; } 
    /// <summary>
    /// Cash movement in to of a fund as a result of investment funds transactions, eg, subscriptions or switch-out.
    /// </summary>
    public CashInForecast1? CashInForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash movement out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    public CashOutForecast1? CashOutForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    public NetCashForecast1? NetCashForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
