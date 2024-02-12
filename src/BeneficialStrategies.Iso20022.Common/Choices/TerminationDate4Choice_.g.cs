﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TerminationDate4Choice.  ISO2002 ID# _ZMYZoTqkEeWyoP0PbocV1Q.
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
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate4Choice.Date))]
    [KnownType(typeof(TerminationDate4Choice.Code))]
    [IsoId("_ZMYZoTqkEeWyoP0PbocV1Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Termination Date 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TerminationDate4Choice_
    #else
    public abstract partial class TerminationDate4Choice_
    #endif
    {
    }
}
