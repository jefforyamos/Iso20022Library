﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInstructedBalanceOptionBalanceDetailsSD2.  ISO2002 ID# _EoBb8b-0Eeeb2ZBoAlSG1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
public partial record CorporateActionInstructedBalanceOptionBalanceDetailsSD2
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Option Number of the extended balances.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Balance of uncovered protect transactions at an option level.
    /// </summary>
    public SignedQuantityFormat9? OptionUncoveredProtectBalance { get; init; } 
    /// <summary>
    /// Daily total of instructions for a given option. Balance will include only made instructions.
    /// </summary>
    public SignedQuantityFormat9? OptionDailyInstructedBalance { get; init; } 
    /// <summary>
    /// For rights subscription events, total number of oversubscribed units. When there is an oversubscription privilege, this quantity will be included within the Instructed quantity in the core message.
    /// </summary>
    public SignedQuantityFormat9? OptionOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// For election merger events, the balance that is being moved into another option number for payment due to the proration of the original option.
    /// </summary>
    public SignedQuantityFormat9? OptionUnacceptedBalance { get; init; } 
    
    #nullable disable
}
