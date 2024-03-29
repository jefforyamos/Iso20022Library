﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesBalanceType9FormatChoice.  ISO2002 ID# _Ro8RwNp-Ed-ak6NoX_4Aeg_-124095903.
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
    /// Choice of formats to express the type of securities balance.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType9FormatChoice.Code))]
    [KnownType(typeof(SecuritiesBalanceType9FormatChoice.Proprietary))]
    [IsoId("_Ro8RwNp-Ed-ak6NoX_4Aeg_-124095903")]
    [DisplayName("Securities Balance Type 9 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType9FormatChoice_
    #else
    public abstract partial class SecuritiesBalanceType9FormatChoice_
    #endif
    {
    }
}
