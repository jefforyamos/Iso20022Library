﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxInformation8.  ISO2002 ID# _wuFOYf7IEeifc-yx3AlK3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
public partial record TaxInformation8
{
    #nullable enable
    
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    public TaxParty1? Creditor { get; init; } 
    /// <summary>
    /// Party on the debit side of the transaction to which the tax applies.
    /// </summary>
    public TaxParty2? Debtor { get; init; } 
    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    public IsoMax35Text? AdministrationZone { get; init; } 
    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    public IsoMax140Text? ReferenceNumber { get; init; } 
    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    public IsoMax35Text? Method { get; init; } 
    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; } 
    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Record of tax details.
    /// </summary>
    public TaxRecord2[] Record { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
