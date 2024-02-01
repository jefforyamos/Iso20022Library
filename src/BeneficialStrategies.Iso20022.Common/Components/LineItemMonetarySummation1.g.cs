﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LineItemMonetarySummation1.  ISO2002 ID# _SucoHAEcEeCQm6a_G2yO_w_1990739481.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade settlement monetary summation specified for this supply chain trade settlement.
/// </summary>
public partial record LineItemMonetarySummation1
{
    #nullable enable
    
    /// <summary>
    /// Monetary value of the line amount total being reported in this trade settlement monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] LineTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all allowance amounts being reported in this line item monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] AllowanceTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all charge amounts being reported in this line item monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] ChargeTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all tax amounts being reported in this line item monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] TaxTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported in this line item monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] TaxBasisTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of an amount being reported for information in this line item monetary summation.
    /// </summary>
    public IsoCurrencyAndAmount[] InformationAmount { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
