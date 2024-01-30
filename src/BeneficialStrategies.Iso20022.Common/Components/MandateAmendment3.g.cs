﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateAmendment3.  ISO2002 ID# _5sMy4SmeEeKdFJmzhTDOvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
public partial record MandateAmendment3
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    public required MandateAmendmentReason1 AmendmentReason { get; init; } 
    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    public required Mandate3 Mandate { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required IOriginalMandate2Choice OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
