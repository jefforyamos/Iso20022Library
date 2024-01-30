﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Commission11.  ISO2002 ID# _RsXZNtp-Ed-ak6NoX_4Aeg_1316757656.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
public partial record Commission11
{
    #nullable enable
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    public CommissionType6Code? Type { get; init; } 
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    public IsoExtended350Code? ExtendedType { get; init; } 
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; } 
    
    #nullable disable
}
