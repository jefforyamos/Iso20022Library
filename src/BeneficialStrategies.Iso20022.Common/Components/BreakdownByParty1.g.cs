﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BreakdownByParty1.  ISO2002 ID# _RP6Gt9p-Ed-ak6NoX_4Aeg_1330321865.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by party.
/// </summary>
public partial record BreakdownByParty1
{
    #nullable enable
    
    /// <summary>
    /// Party, eg, fund management company, for which the cash flow is being reported.
    /// </summary>
    public required PartyIdentification2Choice_ Party { get; init; } 
    /// <summary>
    /// Additional parameter/s applied to the cash flow by party.
    /// </summary>
    public AdditionalParameters1? AdditionalParameters { get; init; } 
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    public CashInForecast3[] CashInForecast { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    public CashOutForecast3[] CashOutForecast { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the party.
    /// </summary>
    public NetCashForecast2[] NetCashForecast { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
