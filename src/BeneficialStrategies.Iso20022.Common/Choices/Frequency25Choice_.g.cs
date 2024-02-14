﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Frequency25Choice.  ISO2002 ID# _bo7ZATeNEeWm5uvLSn0jEw.
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
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency25Choice.Code))]
    [KnownType(typeof(Frequency25Choice.Proprietary))]
    [IsoId("_bo7ZATeNEeWm5uvLSn0jEw")]
    [DisplayName("Frequency 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency25Choice_
    #else
    public abstract partial class Frequency25Choice_
    #endif
    {
    }
}
