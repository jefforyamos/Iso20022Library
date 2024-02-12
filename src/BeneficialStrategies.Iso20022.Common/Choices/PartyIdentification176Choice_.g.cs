﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification176Choice.  ISO2002 ID# _43Snp_fWEeiNZp_PtLohLw.
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
    /// Choice of formats for an identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification176Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification176Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification176Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification176Choice.Country))]
    [IsoId("_43Snp_fWEeiNZp_PtLohLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 176 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification176Choice_
    #else
    public abstract partial class PartyIdentification176Choice_
    #endif
    {
    }
}
