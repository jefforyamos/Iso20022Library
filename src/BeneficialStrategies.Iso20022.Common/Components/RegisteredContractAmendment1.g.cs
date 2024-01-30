﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContractAmendment1.  ISO2002 ID# __zlVIdL3EeSDLevdaFPXHw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment details and reason related to the registered contract.
/// </summary>
public partial record RegisteredContractAmendment1
{
    #nullable enable
    
    /// <summary>
    /// Date of the amendment of the registered contract.
    /// </summary>
    public required IsoISODate AmendmentDate { get; init; } 
    /// <summary>
    /// Reference of the amendment document.
    /// </summary>
    public required DocumentIdentification28 Document { get; init; } 
    /// <summary>
    /// Date from which the amendment is applicable.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Reason for the amendment.
    /// </summary>
    public IsoMax35Text? AmendmentReason { get; init; } 
    /// <summary>
    /// Further details on the amendment.
    /// </summary>
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
