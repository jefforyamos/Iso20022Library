﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party11Choice.  ISO2002 ID# _PWnCwtp-Ed-ak6NoX_4Aeg_2128331948.
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
    [KnownType(typeof(Party11Choice.OrganisationIdentification))]
    [KnownType(typeof(Party11Choice.PrivateIdentification))]
    [IsoId("_PWnCwtp-Ed-ak6NoX_4Aeg_2128331948")]
    [DisplayName("Party 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party11Choice_
    #else
    public abstract partial class Party11Choice_
    #endif
    {
    }
}
