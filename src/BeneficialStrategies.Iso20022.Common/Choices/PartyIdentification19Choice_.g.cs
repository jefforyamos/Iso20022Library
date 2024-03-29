﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification19Choice.  ISO2002 ID# _Sp1N6gEcEeCQm6a_G2yO_w_-1229608165.
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
    /// Identification of a party by a choice between a BIC or a name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification19Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification19Choice.AnyBIC))]
    [IsoId("_Sp1N6gEcEeCQm6a_G2yO_w_-1229608165")]
    [DisplayName("Party Identification 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification19Choice_
    #else
    public abstract partial class PartyIdentification19Choice_
    #endif
    {
    }
}
