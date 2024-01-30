﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateAmendment1.  ISO2002 ID# _RBcz9tp-Ed-ak6NoX_4Aeg_-453440412.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
public partial record MandateAmendment1
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the amendment reason.
    /// </summary>
    public required AmendmentReasonInformation1 AmendmentReason { get; init; } 
    /// <summary>
    /// Set of elements used to provide the amended mandate data.
    /// </summary>
    public required MandateInformation3 Mandate { get; init; } 
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    public required IOriginalMandate1Choice OriginalMandate { get; init; } 
    
    #nullable disable
}
