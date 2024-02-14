﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlingCapacity4Choice.  ISO2002 ID# _m6SEYSW3EeOslcz0TJwprQ.
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
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity4Choice.Code))]
    [KnownType(typeof(SettlingCapacity4Choice.Proprietary))]
    [IsoId("_m6SEYSW3EeOslcz0TJwprQ")]
    [DisplayName("Settling Capacity 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlingCapacity4Choice_
    #else
    public abstract partial class SettlingCapacity4Choice_
    #endif
    {
    }
}
