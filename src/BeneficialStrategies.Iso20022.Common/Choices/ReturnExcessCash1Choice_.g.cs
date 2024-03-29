﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReturnExcessCash1Choice.  ISO2002 ID# _BGt5wALpEeutW5-TpeYJhA.
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
    /// Choice of formats for the return of cash.
    /// </summary>
    [KnownType(typeof(ReturnExcessCash1Choice.Code))]
    [KnownType(typeof(ReturnExcessCash1Choice.Proprietary))]
    [IsoId("_BGt5wALpEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReturnExcessCash1Choice_
    #else
    public abstract partial class ReturnExcessCash1Choice_
    #endif
    {
    }
}
