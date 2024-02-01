﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ThirdPartyRights1.  ISO2002 ID# _kAiCYCC-EeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about third party rights.
/// </summary>
public partial record ThirdPartyRights1
{
    #nullable enable
    
    /// <summary>
    /// Type of third party right.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Timestamp for the third party right.
    /// </summary>
    public IsoISODateTime? DateTime { get; init; } 
    /// <summary>
    /// Party that holds the third party right.
    /// </summary>
    public PartyIdentification70Choice_? Holder { get; init; } 
    /// <summary>
    /// Identification of the holder with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    /// <summary>
    /// Amount of the third party right.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Description of the third party right.
    /// </summary>
    public IsoMax350Text? Description { get; init; } 
    
    #nullable disable
}
