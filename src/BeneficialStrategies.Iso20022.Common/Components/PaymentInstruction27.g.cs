﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction27.  ISO2002 ID# _yVSsYZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment instruction.
/// </summary>
public partial record PaymentInstruction27
{
    #nullable enable
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.|.
    /// </summary>
    public Instruction1Code? Instruction { get; init; } 
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    public PaymentType4Choice_? Type { get; init; } 
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    public PriorityCode3Choice_? Priority { get; init; } 
    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; } 
    
    #nullable disable
}
