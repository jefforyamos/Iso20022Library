﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementMonetarySummation1.  ISO2002 ID# _S-ZInQEcEeCQm6a_G2yO_w_-2077201907.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a collection of monetary totals for this settlement.
/// </summary>
public partial record SettlementMonetarySummation1
{
    #nullable enable
    
    /// <summary>
    /// Monetary value of the line amount total being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] LineTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the allowance total being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] AllowanceTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total discount being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] TotalDiscountAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the charge amount total being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] ChargeTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total prepaid amount being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] TotalPrepaidAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] TaxTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the total of all tax basis amounts being reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] TaxBasisAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of a rounding amount being applied and reported for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] RoundingAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of the grand total being reported for this settlement, to include addition and subtraction of individual summation amounts.
    /// </summary>
    public IsoCurrencyAndAmount[] GrandTotalAmount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value of an amount being reported as information for this settlement.
    /// </summary>
    public IsoCurrencyAndAmount[] InformationAmount { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
