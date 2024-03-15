﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType2Choice.  ISO2002 ID# _QtevF9p-Ed-ak6NoX_4Aeg_-529584274.
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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType2Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType2Choice.Proprietary))]
    [IsoId("_QtevF9p-Ed-ak6NoX_4Aeg_-529584274")]
    [DisplayName("Securities Transaction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType2Choice_
    #else
    public abstract partial class SecuritiesTransactionType2Choice_
    #endif
    {
    }
}
