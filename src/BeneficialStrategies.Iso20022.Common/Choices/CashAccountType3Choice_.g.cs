﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CashAccountType3Choice.  ISO2002 ID# _FQ5iwCCyEeWJd9HF2tO7BA.
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
    /// Choice of formats for the type of cash account.
    /// </summary>
    [KnownType(typeof(CashAccountType3Choice.Code))]
    [KnownType(typeof(CashAccountType3Choice.Proprietary))]
    [IsoId("_FQ5iwCCyEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountType3Choice_
    #else
    public abstract partial class CashAccountType3Choice_
    #endif
    {
    }
}
