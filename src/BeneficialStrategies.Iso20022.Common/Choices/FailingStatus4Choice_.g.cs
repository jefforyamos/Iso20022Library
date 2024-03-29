﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus4Choice.  ISO2002 ID# _Fe4Y0f7rEeCvPoRGOxRobQ.
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
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus4Choice.Reason))]
    [IsoId("_Fe4Y0f7rEeCvPoRGOxRobQ")]
    [DisplayName("Failing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus4Choice_
    #else
    public abstract partial class FailingStatus4Choice_
    #endif
    {
    }
}
