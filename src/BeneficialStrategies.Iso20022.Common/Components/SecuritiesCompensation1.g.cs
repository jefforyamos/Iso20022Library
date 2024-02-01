﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCompensation1.  ISO2002 ID# _Uot1kdp-Ed-ak6NoX_4Aeg_-1569066973.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities compensation such as the depository and the total settlement amount.
/// </summary>
public partial record SecuritiesCompensation1
{
    #nullable enable
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    public required PartyIdentification34Choice_ Depository { get; init; } 
    /// <summary>
    /// Provides the total amount of money to be settled.
    /// </summary>
    public required AmountAndDirection20 SettlementAmount { get; init; } 
    /// <summary>
    /// Amount of money related to the fees for the securities compensation.
    /// </summary>
    public AmountAndDirection20? Fees { get; init; } 
    
    #nullable disable
}
