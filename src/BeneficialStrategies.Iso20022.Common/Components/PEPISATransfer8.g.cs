﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PEPISATransfer8.  ISO2002 ID# _SghaDtp-Ed-ak6NoX_4Aeg_1019608774.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[DataContract]
[XmlType]
public partial record PEPISATransfer8
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [DataMember]
    public required IsoMax35Text TransferIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; } 
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. |The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [DataMember]
    public required ISAYearsOfIssue1 ISA { get; init; } 
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [DataMember]
    public required PreviousYearChoice_ PEP { get; init; } 
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [DataMember]
    public required Portfolio1 Portfolio { get; init; } 
    /// <summary>
    /// Specifies the underlying assets for the PEP, ISA or portfolio.
    /// </summary>
    [DataMember]
    public ValueList<FinancialInstrument11> FinancialInstrumentAssetForTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
