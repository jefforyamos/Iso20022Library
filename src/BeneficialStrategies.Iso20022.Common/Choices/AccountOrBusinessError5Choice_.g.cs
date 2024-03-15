﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountOrBusinessError5Choice.  ISO2002 ID# _fDmr0dcZEeqRFcf2R4bPBw.
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
    /// Choice between account details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError5Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError5Choice.BusinessError))]
    [IsoId("_fDmr0dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Business Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountOrBusinessError5Choice_
    #else
    public abstract partial class AccountOrBusinessError5Choice_
    #endif
    {
    }
}
