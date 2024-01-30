﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation15.  ISO2002 ID# _x_UPKx9REeuFz_FaCzCLgQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
public partial record UpdatedAdditionalInformation15
{
    #nullable enable
    
    /// <summary>
    /// Language used to provide additional information and using the ISO 639-1 language code standard.
    /// </summary>
    public required ISO2ALanguageCode Language { get; init; } 
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; } 
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    public IsoISODate? UpdateDate { get; init; } 
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    public IsoRestrictedFINXMax350Text? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
