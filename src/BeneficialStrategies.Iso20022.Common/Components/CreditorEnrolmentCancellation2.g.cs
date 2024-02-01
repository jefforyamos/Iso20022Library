﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditorEnrolmentCancellation2.  ISO2002 ID# _UedfLeH7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the creditor enrolment to be cancelled.
/// </summary>
public partial record CreditorEnrolmentCancellation2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    public CreditorEnrolmentCancellationReason2? CancellationReason { get; init; } 
    /// <summary>
    /// Provides the original creditor enrolment data.
    /// </summary>
    public required OriginalEnrolment2Choice_ OriginalEnrolment { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
