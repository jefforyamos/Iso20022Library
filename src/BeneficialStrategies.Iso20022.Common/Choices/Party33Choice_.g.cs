﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party33Choice.  ISO2002 ID# _5dylEUzQEea8fovz_9xSTQ.
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
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party33Choice.Organisation))]
    [KnownType(typeof(Party33Choice.IndividualPerson))]
    [IsoId("_5dylEUzQEea8fovz_9xSTQ")]
    [DisplayName("Party 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party33Choice_
    #else
    public abstract partial class Party33Choice_
    #endif
    {
    }
}
