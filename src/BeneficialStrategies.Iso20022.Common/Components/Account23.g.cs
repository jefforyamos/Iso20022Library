﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account23.  ISO2002 ID# _43d7MWB0EeaHEJD5P6-ccw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record Account23
{
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Information about the account to which the existing account is to be linked.
    /// </summary>
    public GenericIdentification1? RelatedAccountDetails { get; init; } 
    
    #nullable disable
}
