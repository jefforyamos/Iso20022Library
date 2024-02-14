﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReservationCriteria4Choice.  ISO2002 ID# _grsrAdcZEeqRFcf2R4bPBw.
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
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria4Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria4Choice.NewCriteria))]
    [IsoId("_grsrAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Criteria 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationCriteria4Choice_
    #else
    public abstract partial class ReservationCriteria4Choice_
    #endif
    {
    }
}
