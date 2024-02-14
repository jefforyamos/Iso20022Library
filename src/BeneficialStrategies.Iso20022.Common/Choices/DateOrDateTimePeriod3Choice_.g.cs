﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateOrDateTimePeriod3Choice.  ISO2002 ID# _Fk5tk_1bEeiAfJEqh4xF_Q.
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
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod3Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod3Choice.DateTime))]
    [IsoId("_Fk5tk_1bEeiAfJEqh4xF_Q")]
    [DisplayName("Date Or Date Time Period 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateOrDateTimePeriod3Choice_
    #else
    public abstract partial class DateOrDateTimePeriod3Choice_
    #endif
    {
    }
}
