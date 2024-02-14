﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClosingBalance4Choice.  ISO2002 ID# _Qd928znGEeWV5sr121Fc8A.
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
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance4Choice.Final))]
    [KnownType(typeof(ClosingBalance4Choice.Intermediary))]
    [IsoId("_Qd928znGEeWV5sr121Fc8A")]
    [DisplayName("Closing Balance 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosingBalance4Choice_
    #else
    public abstract partial class ClosingBalance4Choice_
    #endif
    {
    }
}
