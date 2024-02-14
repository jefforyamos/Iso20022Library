﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateTimePeriod1Choice.  ISO2002 ID# _xLYeBZlcEeeE1Ya-LgRsuQ.
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
    /// Choice between various date time patterns.
    /// </summary>
    [KnownType(typeof(DateTimePeriod1Choice.FromDateTime))]
    [KnownType(typeof(DateTimePeriod1Choice.ToDateTime))]
    [KnownType(typeof(DateTimePeriod1Choice.DateTimeRange))]
    [IsoId("_xLYeBZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date Time Period 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateTimePeriod1Choice_
    #else
    public abstract partial class DateTimePeriod1Choice_
    #endif
    {
    }
}
