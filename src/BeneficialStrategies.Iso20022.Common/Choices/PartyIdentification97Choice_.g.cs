﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification97Choice.  ISO2002 ID# _P50eUSVJEeWI0orciOKunQ.
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
    [KnownType(typeof(PartyIdentification97Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification97Choice.LegalEntityIdentifier))]
    [KnownType(typeof(PartyIdentification97Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification97Choice.ProprietaryIdentification))]
    [IsoId("_P50eUSVJEeWI0orciOKunQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 97 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification97Choice_
    #else
    public abstract partial class PartyIdentification97Choice_
    #endif
    {
    }
}
