﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification125Choice.  ISO2002 ID# _esNO0WpTEeipaMTLlhaKMQ.
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
    /// Choice of formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification125Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification125Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification125Choice.NameAndAddress))]
    [IsoId("_esNO0WpTEeipaMTLlhaKMQ")]
    [DisplayName("Party Identification 125 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification125Choice_
    #else
    public abstract partial class PartyIdentification125Choice_
    #endif
    {
    }
}
