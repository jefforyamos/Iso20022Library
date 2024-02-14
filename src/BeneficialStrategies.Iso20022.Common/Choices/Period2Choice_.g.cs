﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Period2Choice.  ISO2002 ID# _T5exEdp-Ed-ak6NoX_4Aeg_913439020.
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
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period2Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period2Choice.FromDateToDate))]
    [IsoId("_T5exEdp-Ed-ak6NoX_4Aeg_913439020")]
    [DisplayName("Period 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period2Choice_
    #else
    public abstract partial class Period2Choice_
    #endif
    {
    }
}
