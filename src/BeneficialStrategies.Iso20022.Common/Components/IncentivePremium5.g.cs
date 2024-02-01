﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IncentivePremium5.  ISO2002 ID# _uOfjUfNBEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
public partial record IncentivePremium5
{
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    public IsoMax350Text? Description { get; init; } 
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    public required PriceRateOrAmount3Choice_ Amount { get; init; } 
    /// <summary>
    /// Specifies which voting related criteria gives rights to an incentive premium.
    /// </summary>
    public required IncentivePremiumType2Choice_ Type { get; init; } 
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    public DateFormat3Choice_? PaymentDate { get; init; } 
    
    #nullable disable
}
