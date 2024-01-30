﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PledgeeTypeAndText1.  ISO2002 ID# _bBLbIE9fEeSn2-3swbRbzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
/// </summary>
public partial record PledgeeTypeAndText1
{
    #nullable enable
    
    /// <summary>
    /// Additional information about the entity to which the financial instruments are pledged.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    public required PledgeeType1Code PledgeeType { get; init; } 
    
    #nullable disable
}
