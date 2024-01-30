﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge29.  ISO2002 ID# _YSR7ESSBEeWWV-wpfEW00A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Charge29
{
    #nullable enable
    
    /// <summary>
    /// Type of charge.
    /// </summary>
    public required IChargeType4Choice Type { get; init; } 
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Method used to calculate the charge.
    /// </summary>
    public IChargeBasisType1Choice? ChargeBasis { get; init; } 
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    public IPartyIdentification70Choice? RecipientIdentification { get; init; } 
    
    #nullable disable
}
