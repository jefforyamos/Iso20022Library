﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Branch5Choice.  ISO2002 ID# _BpDRkMg4Eeu4ecZgAYuz5w.
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
    /// Specifies the data used to identify the branch of a reporting counterparty.
    /// </summary>
    [KnownType(typeof(Branch5Choice.Identification))]
    [KnownType(typeof(Branch5Choice.Country))]
    [IsoId("_BpDRkMg4Eeu4ecZgAYuz5w")]
    [DisplayName("Branch 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Branch5Choice_
    #else
    public abstract partial class Branch5Choice_
    #endif
    {
    }
}
