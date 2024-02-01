﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification132.  ISO2002 ID# _OevfoU3hEeidB49bWZiS0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification132
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; } 
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public NameAndAddress5? NameAndAddress { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.
    /// </summary>
    public GenericIdentification1? ProprietaryIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
    #nullable disable
}
