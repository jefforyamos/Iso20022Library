﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountSchemeName1Choice.  ISO2002 ID# _P_4pQNp-Ed-ak6NoX_4Aeg_-240227306.
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
    /// Sets of elements to identify a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(AccountSchemeName1Choice.Code))]
    [KnownType(typeof(AccountSchemeName1Choice.Proprietary))]
    [IsoId("_P_4pQNp-Ed-ak6NoX_4Aeg_-240227306")]
    [DisplayName("Account Scheme Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountSchemeName1Choice_
    #else
    public abstract partial class AccountSchemeName1Choice_
    #endif
    {
    }
}
