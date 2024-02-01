﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTypeInformation3.  ISO2002 ID# _TGOIE9p-Ed-ak6NoX_4Aeg_926240939.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further details the information related to the type of payment.
/// </summary>
public partial record PaymentTypeInformation3
{
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    public ServiceLevel2Choice_? ServiceLevel { get; init; } 
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    /// <summary>
    /// User community specific instrument.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    public LocalInstrument1Choice_? LocalInstrument { get; init; } 
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
    /// </summary>
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; } 
    
    #nullable disable
}
