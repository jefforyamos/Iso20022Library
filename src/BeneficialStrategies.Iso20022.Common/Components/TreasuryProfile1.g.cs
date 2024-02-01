﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TreasuryProfile1.  ISO2002 ID# _BzjroCDSEeWCLu74WLgP4w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Treasury trading profile.
/// </summary>
public partial record TreasuryProfile1
{
    #nullable enable
    
    /// <summary>
    /// Execution date of treasury bond trade.
    /// </summary>
    public required IsoISODate Date { get; init; } 
    /// <summary>
    /// Type of party that performs trading operations, for example, investor or custodian.
    /// </summary>
    public required PartyRole5Choice_ TraderType { get; init; } 
    /// <summary>
    /// Tax rate.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    
    #nullable disable
}
