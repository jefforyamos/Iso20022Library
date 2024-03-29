﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateOrName4Choice.  ISO2002 ID# _KYxnQRIlEeyLzJfz3xPQNA.
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
    /// Choice between a percentage rate or a rate index or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName4Choice.Rate))]
    [KnownType(typeof(RateOrName4Choice.RateIndexDetails))]
    [IsoId("_KYxnQRIlEeyLzJfz3xPQNA")]
    [DisplayName("Rate Or Name 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrName4Choice_
    #else
    public abstract partial class RateOrName4Choice_
    #endif
    {
    }
}
