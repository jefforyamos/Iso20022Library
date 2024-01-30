﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralInvestment2.  ISO2002 ID# _hoXEsZNuEembCsVG-3f_AA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a general investment.
/// </summary>
public partial record GeneralInvestment2
{
    #nullable enable
    
    /// <summary>
    /// Type of investment.
    /// </summary>
    public IGeneralInvestmentAccountType2Choice? Type { get; init; } 
    /// <summary>
    /// Specifies whether the account is, for example, in a nominee name or own name.
    /// </summary>
    public AccountOwnershipType6Code? OwnershipType { get; init; } 
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? CurrentInvestmentAmount { get; init; } 
    /// <summary>
    /// Estimated value of the assets.
    /// </summary>
    public DateAndAmount2? EstimatedValue { get; init; } 
    /// <summary>
    /// Additional information about the portfolio.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
