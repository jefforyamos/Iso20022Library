﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification13Choice.  ISO2002 ID# _QQIEsNp-Ed-ak6NoX_4Aeg_-1062714307.
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
    [KnownType(typeof(PartyIdentification13Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification13Choice.ProprietaryIdentification))]
    [IsoId("_QQIEsNp-Ed-ak6NoX_4Aeg_-1062714307")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 13 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification13Choice_
    #else
    public abstract partial class PartyIdentification13Choice_
    #endif
    {
    }
}
