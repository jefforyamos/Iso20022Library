﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstructionProcessingStatus26Choice.  ISO2002 ID# _8QcO2ZNLEeWGlc8L7oPDIg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus26Choice.Code))]
    [KnownType(typeof(InstructionProcessingStatus26Choice.Proprietary))]
    [IsoId("_8QcO2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus26Choice_
    #else
    public abstract partial class InstructionProcessingStatus26Choice_
    #endif
    {
    }
}
