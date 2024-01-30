﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PledgeeTypeAndAnyBICIdentifier1.  ISO2002 ID# _nYzxEE9dEeSn2-3swbRbzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
/// </summary>
public partial record PledgeeTypeAndAnyBICIdentifier1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged, expressed as a BIC.
    /// </summary>
    public required IsoAnyBICIdentifier Identification { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    
    #nullable disable
}
