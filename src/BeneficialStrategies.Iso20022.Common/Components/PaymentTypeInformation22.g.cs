﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTypeInformation22.  ISO2002 ID# _THQp5tp-Ed-ak6NoX_4Aeg_594971445.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details of the type of payment.
/// </summary>
public partial record PaymentTypeInformation22
{
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    public IServiceLevel8Choice? ServiceLevel { get; init; } 
    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    public ILocalInstrument2Choice? LocalInstrument { get; init; } 
    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    public SequenceType1Code? SequenceType { get; init; } 
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    public ICategoryPurpose1Choice? CategoryPurpose { get; init; } 
    
    #nullable disable
}
