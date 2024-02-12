﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DateFormat5Choice.  ISO2002 ID# _Qy_hN9p-Ed-ak6NoX_4Aeg_407445243.
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
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat5Choice.Date))]
    [KnownType(typeof(DateFormat5Choice.DateCode))]
    [IsoId("_Qy_hN9p-Ed-ak6NoX_4Aeg_407445243")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Format 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat5Choice_
    #else
    public abstract partial class DateFormat5Choice_
    #endif
    {
    }
}
