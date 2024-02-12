﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AccountIdentification1Choice.  ISO2002 ID# _Pdd4t9p-Ed-ak6NoX_4Aeg_2089502043.
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
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification1Choice.IBAN))]
    [KnownType(typeof(AccountIdentification1Choice.BBAN))]
    [KnownType(typeof(AccountIdentification1Choice.UPIC))]
    [KnownType(typeof(AccountIdentification1Choice.DomesticAccount))]
    [IsoId("_Pdd4t9p-Ed-ak6NoX_4Aeg_2089502043")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Identification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification1Choice_
    #else
    public abstract partial class AccountIdentification1Choice_
    #endif
    {
    }
}
