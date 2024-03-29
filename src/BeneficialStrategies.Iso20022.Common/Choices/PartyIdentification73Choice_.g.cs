﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification73Choice.  ISO2002 ID# _JJOcQSjIEeKnA5P_jl2DUw.
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
    /// Identification of a party by a choice between a BIC or a name and address or an LEI.
    /// </summary>
    [KnownType(typeof(PartyIdentification73Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification73Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification73Choice.PartyIdentification))]
    [IsoId("_JJOcQSjIEeKnA5P_jl2DUw")]
    [DisplayName("Party Identification 73 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification73Choice_
    #else
    public abstract partial class PartyIdentification73Choice_
    #endif
    {
    }
}
