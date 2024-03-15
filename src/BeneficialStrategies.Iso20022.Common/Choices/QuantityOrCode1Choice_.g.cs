﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuantityOrCode1Choice.  ISO2002 ID# _9Z368K-VEemJ1NnLPsTFaw.
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
    /// Choice between a quantity or a code value.
    /// </summary>
    [KnownType(typeof(QuantityOrCode1Choice.Quantity))]
    [KnownType(typeof(QuantityOrCode1Choice.Code))]
    [IsoId("_9Z368K-VEemJ1NnLPsTFaw")]
    [DisplayName("Quantity Or Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityOrCode1Choice_
    #else
    public abstract partial class QuantityOrCode1Choice_
    #endif
    {
    }
}
