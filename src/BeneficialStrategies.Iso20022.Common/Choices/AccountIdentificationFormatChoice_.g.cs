﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentificationFormatChoice.  ISO2002 ID# _RBvu5dp-Ed-ak6NoX_4Aeg_1713990380.
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
    /// Choice between formats for account identification.
    /// </summary>
    [KnownType(typeof(AccountIdentificationFormatChoice.SimpleIdentification))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAndPurpose))]
    [KnownType(typeof(AccountIdentificationFormatChoice.IdentificationAsDSS))]
    [IsoId("_RBvu5dp-Ed-ak6NoX_4Aeg_1713990380")]
    [DisplayName("Account Identification Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentificationFormatChoice_
    #else
    public abstract partial class AccountIdentificationFormatChoice_
    #endif
    {
    }
}
