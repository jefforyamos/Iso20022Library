﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Pension6.  ISO2002 ID# _YVtxR-lqEeuvhrZwLF0fDg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
public partial record Pension6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    public PensionPolicy1? Identification { get; init; } 
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    public IPensionSchemeType3Choice? Type { get; init; } 
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    public IPensionTransferScope1Choice? TransferScope { get; init; } 
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
