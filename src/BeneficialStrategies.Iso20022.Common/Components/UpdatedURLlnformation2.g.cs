﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedURLlnformation2.  ISO2002 ID# _peeBq0EGEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
public partial record UpdatedURLlnformation2
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
    /// Provides the web address, that is, the address for the Universal Resource Locator (URL), to use over the www (HTTP) service where additional information may be found.
    /// </summary>
    public required IsoMax256Text URLAddress { get; init; } 
    
    #nullable disable
}
