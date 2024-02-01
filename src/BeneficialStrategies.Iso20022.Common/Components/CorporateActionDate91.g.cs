﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate91.  ISO2002 ID# _QUy-OV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
public partial record CorporateActionDate91
{
    #nullable enable
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    public DateFormat49Choice_? TradingDate { get; init; } 
    
    #nullable disable
}
