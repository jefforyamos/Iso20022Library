﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralSubstitution2.  ISO2002 ID# _0UbmsmA3EeSMf75YyPqG7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral that will be substituted.
/// </summary>
public partial record CollateralSubstitution2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// </summary>
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; } 
    /// <summary>
    /// Cash value of the requested collateral substitution transfer in the base currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount SubstitutionRequirement { get; init; } 
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// </summary>
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; } 
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    public SecuritiesCollateral4? SecuritiesCollateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    public CashCollateral5? CashCollateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    public OtherCollateral4? OtherCollateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides details on the identification of previously sent and/or received message(s), in case of updated substitution request.
    /// </summary>
    public Reference17? LinkedReferences { get; init; } 
    
    #nullable disable
}
