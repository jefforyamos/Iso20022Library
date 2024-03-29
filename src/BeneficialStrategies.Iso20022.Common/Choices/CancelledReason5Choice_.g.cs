﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledReason5Choice.  ISO2002 ID# _dHW15VhlEeSsH9MSoogb7Q.
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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason5Choice.Code))]
    [KnownType(typeof(CancelledReason5Choice.Proprietary))]
    [IsoId("_dHW15VhlEeSsH9MSoogb7Q")]
    [DisplayName("Cancelled Reason 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledReason5Choice_
    #else
    public abstract partial class CancelledReason5Choice_
    #endif
    {
    }
}
