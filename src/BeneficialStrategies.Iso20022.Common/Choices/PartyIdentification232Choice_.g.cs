﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification232Choice.  ISO2002 ID# _pEgmUfQ0EeqAradXpAelDQ.
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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification232Choice.LegalPerson))]
    [KnownType(typeof(PartyIdentification232Choice.NaturalPerson))]
    [IsoId("_pEgmUfQ0EeqAradXpAelDQ")]
    [DisplayName("Party Identification 232 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification232Choice_
    #else
    public abstract partial class PartyIdentification232Choice_
    #endif
    {
    }
}
