﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification49Choice.  ISO2002 ID# _K1u4YeaOEd-q8fx_Zl_34A.
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
    [KnownType(typeof(PartyIdentification49Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification49Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification49Choice.NameAndAddress))]
    [IsoId("_K1u4YeaOEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 49 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification49Choice_
    #else
    public abstract partial class PartyIdentification49Choice_
    #endif
    {
    }
}
