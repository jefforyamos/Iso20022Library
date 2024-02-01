﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AffirmationReason1.  ISO2002 ID# _A6DC49okEeC60axPepSq7g_1097982212.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
public partial record AffirmationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction/request has a unaffirmed status.
    /// </summary>
    public required UnaffirmedReason2Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
