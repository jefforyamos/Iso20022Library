﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeniedStatus17Choice.  ISO2002 ID# __JBgITw9EeW3QqUkIQtIUA.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus17Choice.Reason))]
    [IsoId("__JBgITw9EeW3QqUkIQtIUA")]
    [DisplayName("Denied Status 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeniedStatus17Choice_
    #else
    public abstract partial class DeniedStatus17Choice_
    #endif
    {
    }
}
