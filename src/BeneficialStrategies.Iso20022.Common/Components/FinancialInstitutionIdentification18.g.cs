﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification18.  ISO2002 ID# _8xXCNW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details to identify a financial institution.
/// </summary>
public partial record FinancialInstitutionIdentification18
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    public ClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; init; } 
    /// <summary>
    /// Legal entity identifier of the financial institution.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Name by which an agent is known and which is usually used to identify that agent.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public PostalAddress24? PostalAddress { get; init; } 
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    public GenericFinancialIdentification1? Other { get; init; } 
    
    #nullable disable
}
