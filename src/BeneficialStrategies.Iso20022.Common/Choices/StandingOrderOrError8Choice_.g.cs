﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StandingOrderOrError8Choice.  ISO2002 ID# _eb5ypdcZEeqRFcf2R4bPBw.
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
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError8Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError8Choice.BusinessError))]
    [IsoId("_eb5ypdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or Error 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StandingOrderOrError8Choice_
    #else
    public abstract partial class StandingOrderOrError8Choice_
    #endif
    {
    }
}
