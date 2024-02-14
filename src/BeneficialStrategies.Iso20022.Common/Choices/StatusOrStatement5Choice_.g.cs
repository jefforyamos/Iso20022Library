﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatusOrStatement5Choice.  ISO2002 ID# _BTEbgf7yEeCvPoRGOxRobQ.
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
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement5Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement5Choice.Statement))]
    [IsoId("_BTEbgf7yEeCvPoRGOxRobQ")]
    [DisplayName("Status Or Statement 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement5Choice_
    #else
    public abstract partial class StatusOrStatement5Choice_
    #endif
    {
    }
}
