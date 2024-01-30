﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Rating1.  ISO2002 ID# _S1iAuNp-Ed-ak6NoX_4Aeg_-610008315.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Assessment of securities credit and investment risk.
/// </summary>
public partial record Rating1
{
    #nullable enable
    
    /// <summary>
    /// Information regarding the entity that assigns the rating.
    /// </summary>
    public required IsoMax35Text RatingScheme { get; init; } 
    /// <summary>
    /// Date/time as from which the rating is valid.
    /// </summary>
    public required IsoISODateTime ValueDate { get; init; } 
    /// <summary>
    /// Specifies the rating, which has been assigned to a security by a rating agency.
    /// </summary>
    public required IsoRatingValueIdentifier ValueIdentification { get; init; } 
    
    #nullable disable
}
