﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charges3.  ISO2002 ID# _tisYa1kyEeGeoaLUQk__nA_-1567404898.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the charges related to the payment transaction.
/// </summary>
public partial record Charges3
{
    #nullable enable
    
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; } 
    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    public ChargesRecord1[] Record { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
