﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnitOfMeasure5Choice.  ISO2002 ID# _arSvUPp2EeaQh_7a05rSJQ.
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
    /// Specifies a unit of measure.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure5Choice.Code))]
    [KnownType(typeof(UnitOfMeasure5Choice.Proprietary))]
    [IsoId("_arSvUPp2EeaQh_7a05rSJQ")]
    [DisplayName("Unit Of Measure 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure5Choice_
    #else
    public abstract partial class UnitOfMeasure5Choice_
    #endif
    {
    }
}
