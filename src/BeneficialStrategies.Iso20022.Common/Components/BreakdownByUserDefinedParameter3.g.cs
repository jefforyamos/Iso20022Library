﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BreakdownByUserDefinedParameter3.  ISO2002 ID# _KigjuQatEeS3lpTattq7hg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by a user defined parameter/s.
/// </summary>
public partial record BreakdownByUserDefinedParameter3
{
    #nullable enable
    
    /// <summary>
    /// Party for which the cash flow is being reported.
    /// </summary>
    public InvestmentAccount42? Party { get; init; } 
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Parameter for which the cash flow is being reported.
    /// </summary>
    public IDataFormat2Choice? UserDefined { get; init; } 
    /// <summary>
    /// Cash movement into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    public CashInForecast5? CashInForecast { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash movement out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    public CashOutForecast5? CashOutForecast { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the user defined parameter.
    /// </summary>
    public NetCashForecast4? NetCashForecast { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
