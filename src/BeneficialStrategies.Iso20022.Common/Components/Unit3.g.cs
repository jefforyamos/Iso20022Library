﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Unit3.  ISO2002 ID# _Soaxx9p-Ed-ak6NoX_4Aeg_-1327228212.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the units to settle.
/// </summary>
public partial record Unit3
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Date upon which the investor purchased the financial instrument.
    /// </summary>
    public IsoISODate? AcquisitionDate { get; init; } 
    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    public IsoMax35Text[] CertificateNumber { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
    /// <summary>
    /// Information related to the price of the transferred units.
    /// </summary>
    public UnitPrice12? PriceDetails { get; init; } 
    
    #nullable disable
}
