﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyProgramme1.  ISO2002 ID# _kSpocF--Eee_oqB7UglxLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty programme used for partial payment in loyalty value (debit) and computation of loyalty value gained on the monetary value paid by the customer (credit).
/// </summary>
public partial record LoyaltyProgramme1
{
    #nullable enable
    
    /// <summary>
    /// Eligibility for loyalty.
    /// True: Eligible for loyalty
    /// False: Not eligible for loyalty
    /// Default: False.
    /// </summary>
    public IsoTrueFalseIndicator? ProgrammeEligibilityIndicator { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity issuing the loyalty programme.
    /// </summary>
    public IsoMax35Text? ProgrammeIssuer { get; init; } 
    /// <summary>
    /// Details about the member of the loyalty programme
    /// </summary>
    public LoyaltyMember1? LoyaltyMember { get; init; } 
    
    #nullable disable
}
