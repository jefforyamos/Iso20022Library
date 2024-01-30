﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActivationStatus2.  ISO2002 ID# _Ug_1x-H7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of a debtor activation.
/// </summary>
public partial record ActivationStatus2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    /// <summary>
    /// Provides detailed information on the status of the request.
    /// </summary>
    public required IServiceStatus1Choice Status { get; init; } 
    /// <summary>
    /// Specifies the reason for the status of the debtor activation request.
    /// </summary>
    public DebtorActivationStatusReason2? StatusReason { get; init; } 
    /// <summary>
    /// Provides the reference of the original activation request.
    /// </summary>
    public IOriginalActivation2Choice? OriginalActivationReference { get; init; } 
    /// <summary>
    /// Effective date when the debtor has been activated.
    /// </summary>
    public IDateAndDateTime2Choice? EffectiveActivationDate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
