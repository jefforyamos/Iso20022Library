﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Amount1Choice.  ISO2002 ID# _95C-hHltEeG7BsjMvd1mEw_1631956892.
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
    /// Choice of amounts.
    /// </summary>
    [KnownType(typeof(Amount1Choice.IncreaseAmount))]
    [KnownType(typeof(Amount1Choice.DecreaseAmount))]
    [IsoId("_95C-hHltEeG7BsjMvd1mEw_1631956892")]
    [DisplayName("Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Amount1Choice_
    #else
    public abstract partial class Amount1Choice_
    #endif
    {
    }
}
