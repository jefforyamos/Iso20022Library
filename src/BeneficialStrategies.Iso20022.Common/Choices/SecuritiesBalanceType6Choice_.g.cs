﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesBalanceType6Choice.  ISO2002 ID# _qYOkNTnsEeWfSKvvZlhRKg.
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
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType6Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType6Choice.Proprietary))]
    [IsoId("_qYOkNTnsEeWfSKvvZlhRKg")]
    [DisplayName("Securities Balance Type 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType6Choice_
    #else
    public abstract partial class SecuritiesBalanceType6Choice_
    #endif
    {
    }
}
