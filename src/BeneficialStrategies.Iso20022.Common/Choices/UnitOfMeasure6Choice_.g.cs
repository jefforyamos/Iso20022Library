﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnitOfMeasure6Choice.  ISO2002 ID# _QMk1cfFSEee_LsXdoqzkWg.
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
    /// Specifies a unit of measure with a code or free text.
    /// </summary>
    [KnownType(typeof(UnitOfMeasure6Choice.UnitOfMeasureCode))]
    [KnownType(typeof(UnitOfMeasure6Choice.OtherUnitOfMeasure))]
    [IsoId("_QMk1cfFSEee_LsXdoqzkWg")]
    [DisplayName("Unit Of Measure 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOfMeasure6Choice_
    #else
    public abstract partial class UnitOfMeasure6Choice_
    #endif
    {
    }
}
