﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification151Choice.  ISO2002 ID# _ctD2W_fSEeiNZp_PtLohLw.
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
    /// Choice between different formats for the identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification151Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification151Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification151Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification151Choice.LEI))]
    [IsoId("_ctD2W_fSEeiNZp_PtLohLw")]
    [DisplayName("Party Identification 151 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification151Choice_
    #else
    public abstract partial class PartyIdentification151Choice_
    #endif
    {
    }
}
