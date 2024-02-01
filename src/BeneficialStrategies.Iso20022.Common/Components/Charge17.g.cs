﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge17.  ISO2002 ID# _RuKI_Np-Ed-ak6NoX_4Aeg_389288545.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Charge17
{
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    public required ChargeType11Code Type { get; init; } 
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    public required IsoExtended350Code ExtendedType { get; init; } 
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    public IsoExtended350Code? ExtendedChargeBasis { get; init; } 
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    #nullable disable
}
