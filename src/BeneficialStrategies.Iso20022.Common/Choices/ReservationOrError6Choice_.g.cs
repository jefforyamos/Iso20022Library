﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReservationOrError6Choice.  ISO2002 ID# _TanVMZliEeeE1Ya-LgRsuQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// It is used to provide confirmation details of one or more reservations set by the member (or on behalf of the member) and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ReservationOrError6Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError6Choice.OperationalError))]
    [IsoId("_TanVMZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Or Error 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationOrError6Choice_
    #else
    public abstract partial class ReservationOrError6Choice_
    #endif
    {
    }
}
