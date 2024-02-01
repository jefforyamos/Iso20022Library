﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingTerminationNotice1.  ISO2002 ID# _97ufHHltEeG7BsjMvd1mEw_-864278160.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the notification of the termination of an undertaking.
/// </summary>
public partial record UndertakingTerminationNotice1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    public required Undertaking9 UndertakingIdentification { get; init; } 
    /// <summary>
    /// Details related to the termination of the undertaking.
    /// </summary>
    public required UndertakingTermination3 TerminationDetails { get; init; } 
    /// <summary>
    /// Document or template enclosed in the termination notification.
    /// </summary>
    public Document9[] EnclosedFile { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    public IsoMax2000Text[] AdditionalInformation { get; init; } = [];
    
    #nullable disable
}
