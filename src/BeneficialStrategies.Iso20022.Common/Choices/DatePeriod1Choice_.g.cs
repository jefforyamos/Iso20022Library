﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DatePeriod1Choice.  ISO2002 ID# _kaGgU579EeOieb-y7x0pFg.
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
    /// Period as a date, a month or a date time span for which the statement is provided.
    /// </summary>
    [KnownType(typeof(DatePeriod1Choice.Date))]
    [KnownType(typeof(DatePeriod1Choice.DateMonth))]
    [KnownType(typeof(DatePeriod1Choice.FromDateToDate))]
    [IsoId("_kaGgU579EeOieb-y7x0pFg")]
    [DisplayName("Date Period 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DatePeriod1Choice_
    #else
    public abstract partial class DatePeriod1Choice_
    #endif
    {
    }
}
