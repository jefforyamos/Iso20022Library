﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingProcessingStatus4Choice.  ISO2002 ID# _Sn75wf7rEeCvPoRGOxRobQ.
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
    [KnownType(typeof(PendingProcessingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus4Choice.Reason))]
    [IsoId("_Sn75wf7rEeCvPoRGOxRobQ")]
    [DisplayName("Pending Processing Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingStatus4Choice_
    #else
    public abstract partial class PendingProcessingStatus4Choice_
    #endif
    {
    }
}
