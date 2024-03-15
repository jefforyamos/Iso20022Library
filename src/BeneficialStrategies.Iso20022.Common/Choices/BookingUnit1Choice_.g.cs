﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BookingUnit1Choice.  ISO2002 ID# _Q-6dVtp-Ed-ak6NoX_4Aeg_1716011738.
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
    /// Choice between a code or a data source scheme to determine the booking unit.
    /// </summary>
    [KnownType(typeof(BookingUnit1Choice.Code))]
    [KnownType(typeof(BookingUnit1Choice.Proprietary))]
    [IsoId("_Q-6dVtp-Ed-ak6NoX_4Aeg_1716011738")]
    [DisplayName("Booking Unit 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BookingUnit1Choice_
    #else
    public abstract partial class BookingUnit1Choice_
    #endif
    {
    }
}
