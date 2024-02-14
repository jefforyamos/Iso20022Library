﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties8Choice.  ISO2002 ID# _JZdJ0SCBEeWhHbfCMWc1cw.
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
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties8Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties8Choice.Trustee))]
    [KnownType(typeof(AccountParties8Choice.Nominee))]
    [KnownType(typeof(AccountParties8Choice.JointOwner))]
    [IsoId("_JZdJ0SCBEeWhHbfCMWc1cw")]
    [DisplayName("Account Parties 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties8Choice_
    #else
    public abstract partial class AccountParties8Choice_
    #endif
    {
    }
}
