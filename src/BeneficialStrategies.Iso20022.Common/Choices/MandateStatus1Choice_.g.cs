﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MandateStatus1Choice.  ISO2002 ID# _ChH7Y5nAEeao_Z127E9uYg.
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
    /// Sets of elements to identify the status of a mandate.
    /// </summary>
    [KnownType(typeof(MandateStatus1Choice.Code))]
    [KnownType(typeof(MandateStatus1Choice.Proprietary))]
    [IsoId("_ChH7Y5nAEeao_Z127E9uYg")]
    [DisplayName("Mandate Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateStatus1Choice_
    #else
    public abstract partial class MandateStatus1Choice_
    #endif
    {
    }
}
