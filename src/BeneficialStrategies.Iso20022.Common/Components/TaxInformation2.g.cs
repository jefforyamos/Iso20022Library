﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxInformation2.  ISO2002 ID# _RvflsNp-Ed-ak6NoX_4Aeg_-311641782.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[DataContract]
[XmlType]
public partial record TaxInformation2
{
    #nullable enable
    
    /// <summary>
    /// Tax Identification Number of the creditor.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CreditorTaxIdentification { get; init; } 
    /// <summary>
    /// Type of tax payer (creditor).
    /// </summary>
    [DataMember]
    public IsoMax35Text? CreditorTaxType { get; init; } 
    /// <summary>
    /// Tax Identification Number of the debtor.
    /// </summary>
    [DataMember]
    public IsoMax35Text? DebtorTaxIdentification { get; init; } 
    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [DataMember]
    public IsoMax140Text? TaxReferenceNumber { get; init; } 
    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [DataMember]
    public IsoCurrencyAndAmount? TotalTaxableBaseAmount { get; init; } 
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [DataMember]
    public IsoCurrencyAndAmount? TotalTaxAmount { get; init; } 
    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [DataMember]
    public IsoISODate? TaxDate { get; init; } 
    /// <summary>
    /// Set of characteristics defining the type of tax.
    /// </summary>
    [DataMember]
    public ValueList<TaxDetails> TaxTypeInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
