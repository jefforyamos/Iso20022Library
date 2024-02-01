﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Pension.  ISO2002 ID# _YVtxRelqEeuvhrZwLF0fDg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio8Choice;

/// <summary>
/// Portfolio is a pension policy, plan or scheme.
/// </summary>
public partial record Pension : FundPortfolio8Choice_
{
    #nullable enable
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    public PensionPolicy1? Identification { get; init; } 
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    public PensionSchemeType3Choice_? Type { get; init; } 
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    public TaxReference1? TaxReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    /// <summary>
    /// Indicates that the transfer is only in relation to underlying assets, and that the wrapper transfer will occur separately.
    /// </summary>
    public IsoYesNoIndicator? NonWrapperTransfer { get; init; } 
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
