﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountSelection2Choice.  ISO2002 ID# _Ct6vkU_lEeaB8-OWTiMVrQ.
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
    /// Choice of criteria for the identification of an account.
    /// </summary>
    [KnownType(typeof(AccountSelection2Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection2Choice.OtherAccountSelectionData))]
    [IsoId("_Ct6vkU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Selection 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountSelection2Choice_
    #else
    public abstract partial class AccountSelection2Choice_
    #endif
    {
    }
}
