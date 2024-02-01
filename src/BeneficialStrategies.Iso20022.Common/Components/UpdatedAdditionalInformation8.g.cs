﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation8.  ISO2002 ID# _xIm7YUEJEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
public partial record UpdatedAdditionalInformation8
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    public IsoMax140Text? UpdateDescription { get; init; } 
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    public IsoISODate? UpdateDate { get; init; } 
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    public IsoMax8000Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
