﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RestrictionStatus1Choice.  ISO2002 ID# _UWN50CFnEeW9XJWqfgXIIA.
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
    /// Choice of formats for the restriction or limitation status.
    /// </summary>
    [KnownType(typeof(RestrictionStatus1Choice.Code))]
    [KnownType(typeof(RestrictionStatus1Choice.Proprietary))]
    [IsoId("_UWN50CFnEeW9XJWqfgXIIA")]
    [DisplayName("Restriction Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RestrictionStatus1Choice_
    #else
    public abstract partial class RestrictionStatus1Choice_
    #endif
    {
    }
}
