﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CRSSource1Choice.  ISO2002 ID# _JdcmcUNfEeamLdeYEZm56w.
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
    /// Choice of formats for the source of the Common Reporting Standard (CRS).
    /// </summary>
    [KnownType(typeof(CRSSource1Choice.Code))]
    [KnownType(typeof(CRSSource1Choice.Proprietary))]
    [IsoId("_JdcmcUNfEeamLdeYEZm56w")]
    [DisplayName("CRS Source 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CRSSource1Choice_
    #else
    public abstract partial class CRSSource1Choice_
    #endif
    {
    }
}
