﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnitPriceType2Choice.  ISO2002 ID# _N23jAQc_EeSyIPzOZ6VzBQ.
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
    /// Choice of formats for the price type.
    /// </summary>
    [KnownType(typeof(UnitPriceType2Choice.Code))]
    [KnownType(typeof(UnitPriceType2Choice.Proprietary))]
    [IsoId("_N23jAQc_EeSyIPzOZ6VzBQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unit Price Type 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitPriceType2Choice_
    #else
    public abstract partial class UnitPriceType2Choice_
    #endif
    {
    }
}
