﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Commission23.  ISO2002 ID# _hLSRESSDEeWdoOFYMt-Lzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
public partial record Commission23
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    public required ICommissionType3Choice Type { get; init; } 
    /// <summary>
    /// Basis upon which a commission is charged, for example, flat fee.
    /// </summary>
    public ICommissionBasis1Choice? Basis { get; init; } 
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    public IPartyIdentification70Choice? RecipientIdentification { get; init; } 
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    /// <summary>
    /// Voluntary non-enforcement of the right to part of a commission.
    /// </summary>
    public CommissionWaiver4? WaivingDetails { get; init; } 
    
    #nullable disable
}
