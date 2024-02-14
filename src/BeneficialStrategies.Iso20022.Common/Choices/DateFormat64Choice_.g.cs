﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat64Choice.  ISO2002 ID# _TtBUi199Ee262vCSVgjImg.
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
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat64Choice.Date))]
    [KnownType(typeof(DateFormat64Choice.DateCode))]
    [IsoId("_TtBUi199Ee262vCSVgjImg")]
    [DisplayName("Date Format 64 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat64Choice_
    #else
    public abstract partial class DateFormat64Choice_
    #endif
    {
    }
}
