﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BonusWithdrawal2.  ISO2002 ID# _y1unsZzGEembF9M4GR6EAA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a bonus paid out or a withdrawal.
/// </summary>
public partial record BonusWithdrawal2
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the amount is the result of a bonus paid, a withdrawal or other kind of amount.
    /// </summary>
    public required ITypeOfAmount1Choice TypeOfAmount { get; init; } 
    /// <summary>
    /// Amount of the bonus paid or the claimed amount. For example, a claimed amount for a lifetime ISA (LISA) or a government bonus paid out.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    /// <summary>
    /// Reason for the bonus amount paid to or an amount withdrawn from the investment product.
    /// </summary>
    public IWithdrawalReason1Choice? Reason { get; init; } 
    /// <summary>
    /// Amount of an unclaimed bonus or an unclaimed withdrawal.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    /// <summary>
    /// Indicates whether there is an outstanding bonus or withdrawal amount.
    /// </summary>
    public IsoYesNoIndicator? Outstanding { get; init; } 
    /// <summary>
    /// Identification of the withdrawal or bonus.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    /// <summary>
    /// Additional information about the monies paid out or withdrawn.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
