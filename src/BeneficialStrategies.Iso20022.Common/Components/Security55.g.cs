﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Security55.  ISO2002 ID# _Nqo-scg5Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to securities being subject to the transaction.
/// </summary>
public partial record Security55
{
    #nullable enable
    
    /// <summary>
    /// Identifier of the security subject of the transaction.
    /// </summary>
    public IsoISINOct2015Identifier? Identification { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
    /// <summary>
    /// Quantity or nominal amount of the security or commodity subject of the transaction.
    /// </summary>
    public QuantityNominalValue2Choice_? QuantityOrNominalValue { get; init; } 
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    public AmountAndDirection53? MarketValue { get; init; } 
    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    public CollateralQualityType1Code? Quality { get; init; } 
    /// <summary>
    /// Maturity date of the security.
    /// </summary>
    public IsoISODate? Maturity { get; init; } 
    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    public SecurityIssuer4? Issuer { get; init; } 
    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    public SecuritiesLendingType3Choice_[] Type { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indication whether the borrower has exclusive access to borrow from the lender's securities portfolio.
    /// </summary>
    public IsoTrueFalseIndicator? ExclusiveArrangement { get; init; } 
    /// <summary>
    /// Indication whether the collateral taker can reuse the securities provided as a collateral.
    /// </summary>
    public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; } 
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    public IsoPercentageRate? HaircutOrMargin { get; init; } 
    
    #nullable disable
}
