﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MoneyLaunderingCheck1Choice.  ISO2002 ID# _GExWwxdDEeK5g-3oYI0_9Q.
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
    /// Choice of formats for the specification of the money laundering check.
    /// </summary>
    [KnownType(typeof(MoneyLaunderingCheck1Choice.Code))]
    [KnownType(typeof(MoneyLaunderingCheck1Choice.Proprietary))]
    [IsoId("_GExWwxdDEeK5g-3oYI0_9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Money Laundering Check 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MoneyLaunderingCheck1Choice_
    #else
    public abstract partial class MoneyLaunderingCheck1Choice_
    #endif
    {
    }
}
