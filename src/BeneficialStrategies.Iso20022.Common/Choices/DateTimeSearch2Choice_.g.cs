﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateTimeSearch2Choice.  ISO2002 ID# _68F8RX3sEeibM9CPDGCw0g.
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
    /// Choice between search criteria based on dates and date ranges.
    /// </summary>
    [KnownType(typeof(DateTimeSearch2Choice.FromDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.ToDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.FromToDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.EqualDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.NotEqualDateTime))]
    [IsoId("_68F8RX3sEeibM9CPDGCw0g")]
    [DisplayName("Date Time Search 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateTimeSearch2Choice_
    #else
    public abstract partial class DateTimeSearch2Choice_
    #endif
    {
    }
}
