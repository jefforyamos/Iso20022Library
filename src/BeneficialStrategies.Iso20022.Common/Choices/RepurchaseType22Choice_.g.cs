﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepurchaseType22Choice.  ISO2002 ID# _w61AQY-REeaVK-2bgpxeYw.
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
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType22Choice.Code))]
    [KnownType(typeof(RepurchaseType22Choice.Proprietary))]
    [IsoId("_w61AQY-REeaVK-2bgpxeYw")]
    [DisplayName("Repurchase Type 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseType22Choice_
    #else
    public abstract partial class RepurchaseType22Choice_
    #endif
    {
    }
}
