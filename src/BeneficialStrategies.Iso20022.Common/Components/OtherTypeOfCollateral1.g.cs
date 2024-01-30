﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherTypeOfCollateral1.  ISO2002 ID# _Um7s4Np-Ed-ak6NoX_4Aeg_-342642286.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Allows to specify other collateral type by providing a description and the amount.
/// </summary>
public partial record OtherTypeOfCollateral1
{
    #nullable enable
    
    /// <summary>
    /// Provides details about the collateral.
    /// </summary>
    public required IsoMax140Text Description { get; init; } 
    /// <summary>
    /// Amount of the other collateral.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    
    #nullable disable
}
