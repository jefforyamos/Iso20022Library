﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification37Choice.  ISO2002 ID# _7H6pweaPEd-q8fx_Zl_34A.
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
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification37Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification37Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification37Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification37Choice.Country))]
    [IsoId("_7H6pweaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification37Choice_
    #else
    public abstract partial class PartyIdentification37Choice_
    #endif
    {
    }
}
