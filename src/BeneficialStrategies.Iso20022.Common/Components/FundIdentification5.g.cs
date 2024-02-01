﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundIdentification5.  ISO2002 ID# _CQR_IQN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distinct pool of financial instruments managed by a single investment policy. May or may not be part of an umbrella fund.The pool is issued in at least one investment fund class.
/// </summary>
public partial record FundIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the investment fund.
    /// </summary>
    public required PartyIdentification60 FundIdentification { get; init; } 
    /// <summary>
    /// Identifies the account of the fund held with the custodian.
    /// </summary>
    public IsoMax35Text? AccountIdentificationWithCustodian { get; init; } 
    /// <summary>
    /// Identification of the custodian which services the account of the fund.
    /// </summary>
    public PartyIdentification242Choice_? CustodianIdentification { get; init; } 
    
    #nullable disable
}
