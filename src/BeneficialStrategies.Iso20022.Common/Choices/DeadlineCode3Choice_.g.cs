﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeadlineCode3Choice.  ISO2002 ID# _W4fbIUGZEeWqy4niLuXETA.
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
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode3Choice.Code))]
    [KnownType(typeof(DeadlineCode3Choice.Proprietary))]
    [IsoId("_W4fbIUGZEeWqy4niLuXETA")]
    [DisplayName("Deadline Code 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeadlineCode3Choice_
    #else
    public abstract partial class DeadlineCode3Choice_
    #endif
    {
    }
}
