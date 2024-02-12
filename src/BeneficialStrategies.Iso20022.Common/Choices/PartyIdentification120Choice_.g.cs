﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification120Choice.  ISO2002 ID# _Vul5MbpYEeifFaUMRKyMMw.
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
    [KnownType(typeof(PartyIdentification120Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification120Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification120Choice.NameAndAddress))]
    [IsoId("_Vul5MbpYEeifFaUMRKyMMw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 120 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification120Choice_
    #else
    public abstract partial class PartyIdentification120Choice_
    #endif
    {
    }
}
