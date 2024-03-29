﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountType2Choice.  ISO2002 ID# _cyOI8SC7EeWPMvNwVtiMsA.
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
    /// Choice of formats for the specification of the type of account.
    /// </summary>
    [KnownType(typeof(AccountType2Choice.Code))]
    [KnownType(typeof(AccountType2Choice.Proprietary))]
    [IsoId("_cyOI8SC7EeWPMvNwVtiMsA")]
    [DisplayName("Account Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountType2Choice_
    #else
    public abstract partial class AccountType2Choice_
    #endif
    {
    }
}
