﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnderlyingTransaction4Choice.  ISO2002 ID# _hRwhsYKZEee7hrXqLO3yQg.
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
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction4Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction4Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction4Choice.StatementEntry))]
    [IsoId("_hRwhsYKZEee7hrXqLO3yQg")]
    [DisplayName("Underlying Transaction 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction4Choice_
    #else
    public abstract partial class UnderlyingTransaction4Choice_
    #endif
    {
    }
}
