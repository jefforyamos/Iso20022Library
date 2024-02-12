﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification118Choice.  ISO2002 ID# _OtNpsasXEeayv9XxdmMwKQ.
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
    /// Specifies the type of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification118Choice.LEI))]
    [KnownType(typeof(PartyIdentification118Choice.Proprietary))]
    [IsoId("_OtNpsasXEeayv9XxdmMwKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 118 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification118Choice_
    #else
    public abstract partial class PartyIdentification118Choice_
    #endif
    {
    }
}
