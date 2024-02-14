﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties2Choice.  ISO2002 ID# _eTBXkRdQEeK5g-3oYI0_9Q.
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
    /// Party associated with the account.
    /// </summary>
    [KnownType(typeof(AccountParties2Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties2Choice.Trustee))]
    [KnownType(typeof(AccountParties2Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties2Choice.Nominee))]
    [KnownType(typeof(AccountParties2Choice.JointOwner))]
    [IsoId("_eTBXkRdQEeK5g-3oYI0_9Q")]
    [DisplayName("Account Parties 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties2Choice_
    #else
    public abstract partial class AccountParties2Choice_
    #endif
    {
    }
}
