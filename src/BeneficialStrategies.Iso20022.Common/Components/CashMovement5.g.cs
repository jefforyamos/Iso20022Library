﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashMovement5.  ISO2002 ID# _1ahuN5a-EeuPNt5jNVou1A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Movements of cash.
/// </summary>
public partial record CashMovement5
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the cash amount is to be delivered or received.
    /// </summary>
    public required CollateralEntryType1Code CashMovement { get; init; } 
    /// <summary>
    /// Amount of the cash movement
    /// </summary>
    public required IsoActiveCurrencyAndAmount CashAmount { get; init; } 
    /// <summary>
    /// Specifies whether the amount is delivered/received as part of collateral or not.
    /// </summary>
    public required IsoYesNoIndicator CollateralMovement { get; init; } 
    /// <summary>
    /// Reference assigned by party A to the cash movement.
    /// </summary>
    public IsoMax35Text? ClientCashMovementIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by the triparty agent to the cash movement.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCashMovementIdentification { get; init; } 
    
    #nullable disable
}
