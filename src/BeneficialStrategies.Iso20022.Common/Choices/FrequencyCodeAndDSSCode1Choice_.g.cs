﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FrequencyCodeAndDSSCode1Choice.  ISO2002 ID# _Q7Vk5dp-Ed-ak6NoX_4Aeg_1533373090.
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
    /// Choice between formats for the frequency.
    /// </summary>
    [KnownType(typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsCode))]
    [KnownType(typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsDSS))]
    [IsoId("_Q7Vk5dp-Ed-ak6NoX_4Aeg_1533373090")]
    [DisplayName("Frequency Code And DSS Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FrequencyCodeAndDSSCode1Choice_
    #else
    public abstract partial class FrequencyCodeAndDSSCode1Choice_
    #endif
    {
    }
}
