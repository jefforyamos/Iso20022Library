﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat60Choice.  ISO2002 ID# _aBRhWjUIEe2tRf29bleifQ.
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
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat60Choice.Date))]
    [KnownType(typeof(DateFormat60Choice.DateCode))]
    [IsoId("_aBRhWjUIEe2tRf29bleifQ")]
    [DisplayName("Date Format 60 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat60Choice_
    #else
    public abstract partial class DateFormat60Choice_
    #endif
    {
    }
}
