﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AllocationSatus4Choice.  ISO2002 ID# _8QboZZNLEeWGlc8L7oPDIg.
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
    /// Choice of format for the allocation status reason.
    /// </summary>
    [KnownType(typeof(AllocationSatus4Choice.Code))]
    [KnownType(typeof(AllocationSatus4Choice.Proprietary))]
    [IsoId("_8QboZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Allocation Satus 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllocationSatus4Choice_
    #else
    public abstract partial class AllocationSatus4Choice_
    #endif
    {
    }
}
