﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification36Choice.  ISO2002 ID# _qU9DBeaPEd-q8fx_Zl_34A.
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
    [KnownType(typeof(PartyIdentification36Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification36Choice.ProprietaryIdentification))]
    [IsoId("_qU9DBeaPEd-q8fx_Zl_34A")]
    [DisplayName("Party Identification 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification36Choice_
    #else
    public abstract partial class PartyIdentification36Choice_
    #endif
    {
    }
}
