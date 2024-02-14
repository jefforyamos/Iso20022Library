﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BusinessDayReportOrError9Choice.  ISO2002 ID# _N58csXXyEei3jO6riKEVXg.
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
    /// Choice between business day information details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError9Choice.BusinessReport))]
    [KnownType(typeof(BusinessDayReportOrError9Choice.OperationalError))]
    [IsoId("_N58csXXyEei3jO6riKEVXg")]
    [DisplayName("Business Day Report Or Error 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessDayReportOrError9Choice_
    #else
    public abstract partial class BusinessDayReportOrError9Choice_
    #endif
    {
    }
}
