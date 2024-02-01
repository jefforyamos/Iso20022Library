﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndBalance34.  ISO2002 ID# _xuYOMzq3EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
public partial record AccountAndBalance34
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    public required CorporateActionBalanceDetails31 Balance { get; init; } 
    
    #nullable disable
}
