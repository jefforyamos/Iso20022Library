﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatusOrStatement9Choice.  ISO2002 ID# _9a9TMdBxEeihG9bKfarOOA.
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
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement9Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement9Choice.Statement))]
    [IsoId("_9a9TMdBxEeihG9bKfarOOA")]
    [DisplayName("Status Or Statement 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement9Choice_
    #else
    public abstract partial class StatusOrStatement9Choice_
    #endif
    {
    }
}
