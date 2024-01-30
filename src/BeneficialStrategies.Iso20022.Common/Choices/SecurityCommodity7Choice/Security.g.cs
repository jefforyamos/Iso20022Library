﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Security.  ISO2002 ID# _Ul6y8cgyEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityCommodity7Choice;

/// <summary>
/// Data specific to securities being subject to the transaction.
/// </summary>
public partial record Security : ISecurityCommodity7Choice
{
    #nullable enable
    /// <summary>
    /// Specifies whether the values defined as ISIN (International Securities Identification Number-ISO 6166) identifier are matching or not.
    /// </summary>
    public CompareISINIdentifier4? Identification { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
    /// </summary>
    public CompareCFIIdentifier3? ClassificationType { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as decimal number are matching or not.
    /// </summary>
    public CompareDecimalNumber3? Quantity { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    public CompareAmountAndDirection2? NominalValue { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as collateral quality type code are matching or not.
    /// </summary>
    public CompareCollateralQualityType3? Quality { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    public CompareDate3? Maturity { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    public CompareOrganisationIdentification6? IssuerIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as country code are matching or not.
    /// </summary>
    public CompareCountryCode3? IssuerCountry { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as securities lending type are matching or not.
    /// </summary>
    public CompareSecuritiesLendingType3? Type { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether the the unit prices are matching or not.
    /// </summary>
    public CompareUnitPrice6? UnitPrice { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    public CompareTrueFalseIndicator3? ExclusiveArrangement { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    public CompareAmountAndDirection2? MarketValue { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    public CompareTrueFalseIndicator3? AvailableForCollateralReuse { get; init; } 
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    public ComparePercentageRate3? HaircutOrMargin { get; init; } 
    #nullable disable
}
