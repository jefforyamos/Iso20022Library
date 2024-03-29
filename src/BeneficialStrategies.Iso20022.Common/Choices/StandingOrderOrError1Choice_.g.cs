﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StandingOrderOrError1Choice.  ISO2002 ID# _759LdqMgEeCJ6YNENx4h-w_1400148199.
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
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError1Choice.Report))]
    [KnownType(typeof(StandingOrderOrError1Choice.OperationalError))]
    [IsoId("_759LdqMgEeCJ6YNENx4h-w_1400148199")]
    [DisplayName("Standing Order Or Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrError1Choice_
    #else
    public abstract partial class StandingOrderOrError1Choice_
    #endif
    {
    }
}
