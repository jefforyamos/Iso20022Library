﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ResponseStatus6Choice.  ISO2002 ID# _l8zcITzpEeWeNtT0s2RbkQ.
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
    /// Choice of response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus6Choice.Consented))]
    [KnownType(typeof(ResponseStatus6Choice.Rejected))]
    [KnownType(typeof(ResponseStatus6Choice.Pending))]
    [IsoId("_l8zcITzpEeWeNtT0s2RbkQ")]
    [DisplayName("Response Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus6Choice_
    #else
    public abstract partial class ResponseStatus6Choice_
    #endif
    {
    }
}
