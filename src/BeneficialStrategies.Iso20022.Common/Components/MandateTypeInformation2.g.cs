﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateTypeInformation2.  ISO2002 ID# _cm369kjwEeaVLL5QKJ4f-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
public partial record MandateTypeInformation2
{
    #nullable enable
    
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    public IServiceLevel8Choice? ServiceLevel { get; init; } 
    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public ILocalInstrument2Choice? LocalInstrument { get; init; } 
    /// <summary>
    /// Specifies the high level purpose of the mandate based on a set of pre-defined categories.
    /// </summary>
    public ICategoryPurpose1Choice? CategoryPurpose { get; init; } 
    /// <summary>
    /// Type of direct debit instruction.
    /// </summary>
    public IMandateClassification1Choice? Classification { get; init; } 
    
    #nullable disable
}
