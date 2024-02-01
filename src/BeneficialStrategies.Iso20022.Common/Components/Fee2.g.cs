﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Fee2.  ISO2002 ID# _CCuPcUUOEeaFv6weEmLwpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Fee2
{
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    public required ChargeType5Choice_ Type { get; init; } 
    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    public ChargeBasis2Choice_? Basis { get; init; } 
    /// <summary>
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    public IsoActiveCurrencyAndAmount? StandardAmount { get; init; } 
    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee, as specified in the fund prospectus or agreed for the account.
    /// </summary>
    public IsoPercentageRate? StandardRate { get; init; } 
    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; } 
    /// <summary>
    /// Fee (charge/commission) amount applied to the transaction.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AppliedAmount { get; init; } 
    /// <summary>
    /// Final rate used to calculate the fee (charge/commission) amount.
    /// </summary>
    public IsoPercentageRate? AppliedRate { get; init; } 
    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA), such as a fee (charge/commission).
    /// </summary>
    public IsoMax35Text? NonStandardSLAReference { get; init; } 
    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    public PartyIdentification113? RecipientIdentification { get; init; } 
    /// <summary>
    /// Indicates the information is provided for information purposes only. When the value is ‘false’ or ‘0’ the amount provided is taken into consideration in the transaction overhead. When the value is ‘true’ or ‘1’ the amount provided is not taken into consideration in the transaction overhead.
    /// </summary>
    public required IsoYesNoIndicator InformativeIndicator { get; init; } 
    
    #nullable disable
}
