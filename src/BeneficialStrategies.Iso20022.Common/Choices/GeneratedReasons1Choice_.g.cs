﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneratedReasons1Choice.  ISO2002 ID# _UYxVFdp-Ed-ak6NoX_4Aeg_-1972160125.
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
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons1Choice.Code))]
    [KnownType(typeof(GeneratedReasons1Choice.Proprietary))]
    [IsoId("_UYxVFdp-Ed-ak6NoX_4Aeg_-1972160125")]
    [DisplayName("Generated Reasons 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedReasons1Choice_
    #else
    public abstract partial class GeneratedReasons1Choice_
    #endif
    {
    }
}
