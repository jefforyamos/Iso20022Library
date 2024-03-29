﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PoliticalExposureType1Choice.  ISO2002 ID# _c6LHoRRvEeOKWo1NF21OVw.
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
    /// Choice of formats for the specification of the type of political exposure.
    /// </summary>
    [KnownType(typeof(PoliticalExposureType1Choice.Code))]
    [KnownType(typeof(PoliticalExposureType1Choice.Proprietary))]
    [IsoId("_c6LHoRRvEeOKWo1NF21OVw")]
    [DisplayName("Political Exposure Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PoliticalExposureType1Choice_
    #else
    public abstract partial class PoliticalExposureType1Choice_
    #endif
    {
    }
}
