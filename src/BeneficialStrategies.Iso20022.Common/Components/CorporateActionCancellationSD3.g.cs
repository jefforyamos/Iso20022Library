﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionCancellationSD3.  ISO2002 ID# _pm0bkb5XEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding linkage details.
/// </summary>
public partial record CorporateActionCancellationSD3
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
    /// </summary>
    public required IsoMax35Text LinkedCorporateActionIdentification { get; init; } 
    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    public required DTCCLinkType1Code LinkageType { get; init; } 
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was established.
    /// </summary>
    public required IsoISODate LinkAddedDate { get; init; } 
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was modified.
    /// </summary>
    public IsoISODate? LinkModifiedDate { get; init; } 
    
    #nullable disable
}
