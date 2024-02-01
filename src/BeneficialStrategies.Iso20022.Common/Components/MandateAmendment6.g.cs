﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateAmendment6.  ISO2002 ID# _RwtmcW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
public partial record MandateAmendment6
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    public required MandateAmendmentReason2 AmendmentReason { get; init; } 
    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    public required Mandate14 Mandate { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required OriginalMandate6Choice_ OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
