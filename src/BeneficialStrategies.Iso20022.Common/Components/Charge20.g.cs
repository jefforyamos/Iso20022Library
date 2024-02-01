﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge20.  ISO2002 ID# _Rt2m8Np-Ed-ak6NoX_4Aeg_-1889591206.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Charge20
{
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    public required ChargeType12Code Type { get; init; } 
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    public required IsoExtended350Code ExtendedType { get; init; } 
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    public IsoExtended350Code? ExtendedChargeBasis { get; init; } 
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    #nullable disable
}
