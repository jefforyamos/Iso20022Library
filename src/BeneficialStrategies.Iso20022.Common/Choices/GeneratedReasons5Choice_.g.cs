﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneratedReasons5Choice.  ISO2002 ID# _N9GsgTqeEeWyoP0PbocV1Q.
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
    [KnownType(typeof(GeneratedReasons5Choice.Code))]
    [KnownType(typeof(GeneratedReasons5Choice.Proprietary))]
    [IsoId("_N9GsgTqeEeWyoP0PbocV1Q")]
    [DisplayName("Generated Reasons 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedReasons5Choice_
    #else
    public abstract partial class GeneratedReasons5Choice_
    #endif
    {
    }
}
