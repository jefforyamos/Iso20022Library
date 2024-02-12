﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SystemEventType4Choice.  ISO2002 ID# _d7AQEXhkEeidzqjNEfehPg.
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
    /// Specifies the type of system event.
    /// </summary>
    [KnownType(typeof(SystemEventType4Choice.Code))]
    [KnownType(typeof(SystemEventType4Choice.Proprietary))]
    [IsoId("_d7AQEXhkEeidzqjNEfehPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("System Event Type 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemEventType4Choice_
    #else
    public abstract partial class SystemEventType4Choice_
    #endif
    {
    }
}
