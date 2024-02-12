﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AuthenticationChannel1Choice.  ISO2002 ID# _U4Y945dgEea1K6JAcAwoVg.
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
    /// Choice of format for an authentication channel.
    /// </summary>
    [KnownType(typeof(AuthenticationChannel1Choice.Code))]
    [KnownType(typeof(AuthenticationChannel1Choice.Proprietary))]
    [IsoId("_U4Y945dgEea1K6JAcAwoVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authentication Channel 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AuthenticationChannel1Choice_
    #else
    public abstract partial class AuthenticationChannel1Choice_
    #endif
    {
    }
}
