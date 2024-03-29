﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingType1Choice.  ISO2002 ID# _705FQqMgEeCJ6YNENx4h-w_1984754535.
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
    /// Type of processing restrictions.
    /// </summary>
    [KnownType(typeof(ProcessingType1Choice.Code))]
    [KnownType(typeof(ProcessingType1Choice.Proprietary))]
    [IsoId("_705FQqMgEeCJ6YNENx4h-w_1984754535")]
    [DisplayName("Processing Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingType1Choice_
    #else
    public abstract partial class ProcessingType1Choice_
    #endif
    {
    }
}
