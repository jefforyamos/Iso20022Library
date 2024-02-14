﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentification33Choice.  ISO2002 ID# _w9u0bTq3EeWQ1Y7f8kds2A.
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
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification33Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification33Choice.AccountsListAndBalanceDetails))]
    [IsoId("_w9u0bTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Identification 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification33Choice_
    #else
    public abstract partial class AccountIdentification33Choice_
    #endif
    {
    }
}
