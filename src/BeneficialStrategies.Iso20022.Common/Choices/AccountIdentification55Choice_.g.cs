﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentification55Choice.  ISO2002 ID# _enyf0QatEe2phaVG0lYKTw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Unique identifier of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification55Choice.IBAN))]
    [KnownType(typeof(AccountIdentification55Choice.BBAN))]
    [KnownType(typeof(AccountIdentification55Choice.UPIC))]
    [KnownType(typeof(AccountIdentification55Choice.ProprietaryAccount))]
    [IsoId("_enyf0QatEe2phaVG0lYKTw")]
    [DisplayName("Account Identification 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification55Choice_
    #else
    public abstract partial class AccountIdentification55Choice_
    #endif
    {
    }
}
