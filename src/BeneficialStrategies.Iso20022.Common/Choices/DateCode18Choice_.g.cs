﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateCode18Choice.  ISO2002 ID# _ZtQSJzqkEeWyoP0PbocV1Q.
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
    /// Choice of format for the date.
    /// </summary>
    [KnownType(typeof(DateCode18Choice.Code))]
    [KnownType(typeof(DateCode18Choice.Proprietary))]
    [IsoId("_ZtQSJzqkEeWyoP0PbocV1Q")]
    [DisplayName("Date Code 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateCode18Choice_
    #else
    public abstract partial class DateCode18Choice_
    #endif
    {
    }
}
