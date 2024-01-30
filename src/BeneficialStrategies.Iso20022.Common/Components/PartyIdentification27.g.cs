﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification27.  ISO2002 ID# _Pb-D59p-Ed-ak6NoX_4Aeg_-1579248331.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
public partial record PartyIdentification27
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax70Text Name { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned to a party using a proprietary identification scheme.
    /// </summary>
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    /// <summary>
    /// Specifies the country of the party.
    /// </summary>
    public required CountryCode Country { get; init; } 
    
    #nullable disable
}
