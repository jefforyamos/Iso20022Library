﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxAmount2.  ISO2002 ID# _yeA_Fa9fEeen6L7OP7lnvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the tax amount(s) of tax record.
/// </summary>
public partial record TaxAmount2
{
    #nullable enable
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; } 
    /// <summary>
    /// Total amount that is the result of the calculation of the tax for the record.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Set of elements used to provide details on the tax period and amount.
    /// </summary>
    public TaxRecordDetails2[] Details { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
