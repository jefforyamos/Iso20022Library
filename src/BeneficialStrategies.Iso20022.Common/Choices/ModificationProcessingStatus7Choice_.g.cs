﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationProcessingStatus7Choice.  ISO2002 ID# _1bR8UTp4EeWVrPy0StzzSg.
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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.PendingProcessing))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Denied))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Repaired))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Modified))]
    [KnownType(typeof(ModificationProcessingStatus7Choice.Proprietary))]
    [IsoId("_1bR8UTp4EeWVrPy0StzzSg")]
    [DisplayName("Modification Processing Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationProcessingStatus7Choice_
    #else
    public abstract partial class ModificationProcessingStatus7Choice_
    #endif
    {
    }
}
