﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneratedReasons3Choice.  ISO2002 ID# _C2YFzSRhEeO8sskhVI3IDA.
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
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons3Choice.Code))]
    [KnownType(typeof(GeneratedReasons3Choice.Proprietary))]
    [IsoId("_C2YFzSRhEeO8sskhVI3IDA")]
    [DisplayName("Generated Reasons 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedReasons3Choice_
    #else
    public abstract partial class GeneratedReasons3Choice_
    #endif
    {
    }
}
