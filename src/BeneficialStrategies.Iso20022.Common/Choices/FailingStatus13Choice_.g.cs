﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus13Choice.  ISO2002 ID# _9wP7USW-EeygjNFjAlVoPA.
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
    [KnownType(typeof(FailingStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus13Choice.Reason))]
    [IsoId("_9wP7USW-EeygjNFjAlVoPA")]
    [DisplayName("Failing Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FailingStatus13Choice_
    #else
    public abstract partial class FailingStatus13Choice_
    #endif
    {
    }
}
