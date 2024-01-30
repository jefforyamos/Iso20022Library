﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContactDetails4.  ISO2002 ID# _TVX6Ae3mEeaWjpoyrnG6Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
public partial record ContactDetails4
{
    #nullable enable
    
    /// <summary>
    /// Name of the liaison at the Settlement Internaliser.
    /// </summary>
    public required IsoMax140Text Name { get; init; } 
    /// <summary>
    /// Phone number of the liaison at the Settlement Internaliser.
    /// </summary>
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    /// <summary>
    /// Electronic mail (e-mail) address of the liaison at the Settlement Internaliser.
    /// </summary>
    public required IsoMax2048Text EmailAddress { get; init; } 
    /// <summary>
    /// Function of the liaison at the Settlement Internaliser.
    /// </summary>
    public required IsoMax140Text Function { get; init; } 
    
    #nullable disable
}
