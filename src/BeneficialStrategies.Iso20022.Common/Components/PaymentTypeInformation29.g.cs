﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTypeInformation29.  ISO2002 ID# _gXVWIe10Eei2O5Op8j5zpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the type of payment.
/// </summary>
[IsoId("_gXVWIe10Eei2O5Op8j5zpA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Payment Type Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTypeInformation29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_gk4C4-10Eei2O5Op8j5zpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Priority")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority2Code? InstructionPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code? InstructionPriority { get; init; } 
    #else
    public Priority2Code? InstructionPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_gk4C5e10Eei2O5Op8j5zpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Level")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel8Choice_? ServiceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_gk4C5-10Eei2O5Op8j5zpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Instrument")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalInstrument2Choice_? LocalInstrument { get; init; } 
    #else
    public LocalInstrument2Choice_? LocalInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_gk4C6e10Eei2O5Op8j5zpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sequence Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SequenceType3Code? SequenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SequenceType3Code? SequenceType { get; init; } 
    #else
    public SequenceType3Code? SequenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_gk4C6-10Eei2O5Op8j5zpA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Category Purpose")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; } 
    #else
    public CategoryPurpose1Choice_? CategoryPurpose { get; set; } 
    #endif
    
    
    #nullable disable
    
}
