﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxRecord1.  ISO2002 ID# _UP-lfdp-Ed-ak6NoX_4Aeg_-1626596263.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the tax record.
/// </summary>
public partial record TaxRecord1
{
    #nullable enable
    
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    public IsoMax35Text? Category { get; init; } 
    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    public IsoMax35Text? CategoryDetails { get; init; } 
    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    public IsoMax35Text? DebtorStatus { get; init; } 
    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    public IsoMax35Text? CertificateIdentification { get; init; } 
    /// <summary>
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    public IsoMax35Text? FormsCode { get; init; } 
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    public TaxPeriod1? Period { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    public TaxAmount1? TaxAmount { get; init; } 
    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
