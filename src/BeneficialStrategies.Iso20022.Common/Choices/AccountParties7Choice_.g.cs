﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties7Choice.  ISO2002 ID# _JYYKawhDEeSUPbC7DbLJpQ.
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
    [KnownType(typeof(AccountParties7Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties7Choice.Trustee))]
    [KnownType(typeof(AccountParties7Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties7Choice.Nominee))]
    [KnownType(typeof(AccountParties7Choice.JointOwner))]
    [IsoId("_JYYKawhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties7Choice_
    #else
    public abstract partial class AccountParties7Choice_
    #endif
    {
    }
}
