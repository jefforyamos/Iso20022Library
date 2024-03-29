﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatusOrStatement1Choice.  ISO2002 ID# _QqNYodp-Ed-ak6NoX_4Aeg_-151525982.
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
    /// Choice between the identification of a status or statement query.
    /// </summary>
    [KnownType(typeof(StatusOrStatement1Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement1Choice.Statement))]
    [IsoId("_QqNYodp-Ed-ak6NoX_4Aeg_-151525982")]
    [DisplayName("Status Or Statement 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrStatement1Choice_
    #else
    public abstract partial class StatusOrStatement1Choice_
    #endif
    {
    }
}
