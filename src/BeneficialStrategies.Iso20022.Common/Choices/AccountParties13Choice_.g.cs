﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountParties13Choice.  ISO2002 ID# _oK88BZQ_EemqYPWMBuVawg.
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
    /// Information about a party's account.
    /// </summary>
    [KnownType(typeof(AccountParties13Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties13Choice.Trustee))]
    [KnownType(typeof(AccountParties13Choice.Nominee))]
    [KnownType(typeof(AccountParties13Choice.JointOwner))]
    [IsoId("_oK88BZQ_EemqYPWMBuVawg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Parties 13 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties13Choice_
    #else
    public abstract partial class AccountParties13Choice_
    #endif
    {
    }
}
