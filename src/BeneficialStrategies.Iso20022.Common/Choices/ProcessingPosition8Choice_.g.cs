﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition8Choice.  ISO2002 ID# _l5LCHTt4EeW638lNyHKv7A.
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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition8Choice.Code))]
    [KnownType(typeof(ProcessingPosition8Choice.Proprietary))]
    [IsoId("_l5LCHTt4EeW638lNyHKv7A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Position 8 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition8Choice_
    #else
    public abstract partial class ProcessingPosition8Choice_
    #endif
    {
    }
}
