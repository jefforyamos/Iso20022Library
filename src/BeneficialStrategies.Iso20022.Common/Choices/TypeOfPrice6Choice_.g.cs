﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TypeOfPrice6Choice.  ISO2002 ID# _Qwdxpdp-Ed-ak6NoX_4Aeg_-1053429608.
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
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice6Choice.Code))]
    [KnownType(typeof(TypeOfPrice6Choice.Proprietary))]
    [IsoId("_Qwdxpdp-Ed-ak6NoX_4Aeg_-1053429608")]
    [DisplayName("Type Of Price 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TypeOfPrice6Choice_
    #else
    public abstract partial class TypeOfPrice6Choice_
    #endif
    {
    }
}
