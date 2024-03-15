﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification113Choice.  ISO2002 ID# _ckJthZKQEeWHWpTQn1FFVg.
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
    [KnownType(typeof(PartyIdentification113Choice.BICFI))]
    [KnownType(typeof(PartyIdentification113Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification113Choice.ProprietaryIdentification))]
    [IsoId("_ckJthZKQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 113 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification113Choice_
    #else
    public abstract partial class PartyIdentification113Choice_
    #endif
    {
    }
}
