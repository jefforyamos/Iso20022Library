﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Fee3.  ISO2002 ID# _ouYtsTk2EeapUO0vUIo9Xw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Fee3
{
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    public IChargeType5Choice? Type { get; init; } 
    /// <summary>
    /// Modified value of the standard fee (charge/commission) amount applied on the order (the standard fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedStandardAmount { get; init; } 
    /// <summary>
    /// Modified value of the standard fee (charge/commission) rate applied on the order (the standard fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedStandardRate { get; init; } 
    /// <summary>
    /// Modified value of the discount amount applied on the order (the discount amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; } 
    /// <summary>
    /// Modified value of the discount rate applied on the order (the discount rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedDiscountRate { get; init; } 
    /// <summary>
    /// Modified value of the requested fee (charge/commission) amount applied on the order (the requested fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; } 
    /// <summary>
    /// Modified value of the requested fee (charge/commission) rate applied on the order (the requested fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedRequestedRate { get; init; } 
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
