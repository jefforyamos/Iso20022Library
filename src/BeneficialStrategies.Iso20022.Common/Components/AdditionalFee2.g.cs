﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalFee2.  ISO2002 ID# _xv70MYdGEeuBS50MFjViNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees not included in the transaction.
/// </summary>
public partial record AdditionalFee2
{
    #nullable enable
    
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    public required TypeOfAmount21Code Type { get; init; } 
    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Identification of fee program.
    /// </summary>
    public IsoMax35Text? FeeProgram { get; init; } 
    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    public IsoMax35Text? FeeDescriptor { get; init; } 
    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    public required FeeAmount3 FeeAmount { get; init; } 
    /// <summary>
    /// Contains the fee amount in reconciliation currency.
    /// </summary>
    public FeeAmount3? FeeReconciliationAmount { get; init; } 
    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
