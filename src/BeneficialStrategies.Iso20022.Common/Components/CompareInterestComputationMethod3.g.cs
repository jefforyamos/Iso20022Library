﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareInterestComputationMethod3.  ISO2002 ID# _Dhvyga5jEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for the method used to compute accruing interest of a financial instrument.
/// </summary>
public partial record CompareInterestComputationMethod3
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IInterestComputationMethodFormat6Choice? Value1 { get; init; } 
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public IInterestComputationMethodFormat6Choice? Value2 { get; init; } 
    
    #nullable disable
}
