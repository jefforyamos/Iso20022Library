﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationReason2.  ISO2002 ID# _0jhc9AlIEeGATtfOBToyew_665393579.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification reasons.
/// </summary>
public partial record ModificationReason2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the transaction is modified.
    /// </summary>
    public required ModificationReason2Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
