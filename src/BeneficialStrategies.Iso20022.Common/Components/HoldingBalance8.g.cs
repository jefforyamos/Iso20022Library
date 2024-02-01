﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldingBalance8.  ISO2002 ID# __b2CMVtkEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account,for example, sub-balance per status.
/// </summary>
public partial record HoldingBalance8
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    public required UnitOrFaceAmountOrCode1Choice_ Balance { get; init; } 
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    public SecuritiesEntryType2Code? BalanceType { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; } 
    
    #nullable disable
}
