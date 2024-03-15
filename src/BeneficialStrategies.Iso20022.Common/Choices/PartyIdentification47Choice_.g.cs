﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification47Choice.  ISO2002 ID# _rFE_oeaMEd-q8fx_Zl_34A.
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
    [KnownType(typeof(PartyIdentification47Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification47Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification47Choice.NameAndAddress))]
    [IsoId("_rFE_oeaMEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification47Choice_
    #else
    public abstract partial class PartyIdentification47Choice_
    #endif
    {
    }
}
