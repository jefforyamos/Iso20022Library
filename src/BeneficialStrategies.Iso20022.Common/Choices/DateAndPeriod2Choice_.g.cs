﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateAndPeriod2Choice.  ISO2002 ID# _76Z3ZaMgEeCJ6YNENx4h-w_1548347311.
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
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod2Choice.Date))]
    [KnownType(typeof(DateAndPeriod2Choice.Period))]
    [KnownType(typeof(DateAndPeriod2Choice.FromDate))]
    [KnownType(typeof(DateAndPeriod2Choice.ToDate))]
    [IsoId("_76Z3ZaMgEeCJ6YNENx4h-w_1548347311")]
    [DisplayName("Date And Period 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndPeriod2Choice_
    #else
    public abstract partial class DateAndPeriod2Choice_
    #endif
    {
    }
}
