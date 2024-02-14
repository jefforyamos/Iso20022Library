﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification248Choice.  ISO2002 ID# _V_oRsT3YEe2uHKhHp3bXyA.
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
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(PartyIdentification248Choice.Legal))]
    [KnownType(typeof(PartyIdentification248Choice.Natural))]
    [IsoId("_V_oRsT3YEe2uHKhHp3bXyA")]
    [DisplayName("Party Identification 248 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification248Choice_
    #else
    public abstract partial class PartyIdentification248Choice_
    #endif
    {
    }
}
