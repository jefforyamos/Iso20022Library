﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriorityCode3Choice.  ISO2002 ID# _5FjlARbwEeOy-PlRuFSUzQ.
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
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(PriorityCode3Choice.Code))]
    [KnownType(typeof(PriorityCode3Choice.Proprietary))]
    [IsoId("_5FjlARbwEeOy-PlRuFSUzQ")]
    [DisplayName("Priority Code 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriorityCode3Choice_
    #else
    public abstract partial class PriorityCode3Choice_
    #endif
    {
    }
}
