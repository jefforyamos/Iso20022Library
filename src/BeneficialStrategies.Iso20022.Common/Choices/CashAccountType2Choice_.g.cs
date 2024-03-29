﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashAccountType2Choice.  ISO2002 ID# _sb6WgFkyEeGeoaLUQk__nA_1768299331.
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
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(CashAccountType2Choice.Code))]
    [KnownType(typeof(CashAccountType2Choice.Proprietary))]
    [IsoId("_sb6WgFkyEeGeoaLUQk__nA_1768299331")]
    [DisplayName("Cash Account Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountType2Choice_
    #else
    public abstract partial class CashAccountType2Choice_
    #endif
    {
    }
}
