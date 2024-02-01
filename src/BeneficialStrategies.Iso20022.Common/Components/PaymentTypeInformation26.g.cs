﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTypeInformation26.  ISO2002 ID# _YPH8YXR0EeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the type of payment.
/// </summary>
public partial record PaymentTypeInformation26
{
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    public ServiceLevel8Choice_[] ServiceLevel { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    
    #nullable disable
}
