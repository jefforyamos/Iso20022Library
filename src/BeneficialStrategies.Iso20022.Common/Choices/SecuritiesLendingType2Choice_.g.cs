﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesLendingType2Choice.  ISO2002 ID# _KZ4B0ZEkEeakHoV5BVecAQ.
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
    /// Choice of format for the securities lending type.
    /// </summary>
    [KnownType(typeof(SecuritiesLendingType2Choice.Code))]
    [KnownType(typeof(SecuritiesLendingType2Choice.Proprietary))]
    [IsoId("_KZ4B0ZEkEeakHoV5BVecAQ")]
    [DisplayName("Securities Lending Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesLendingType2Choice_
    #else
    public abstract partial class SecuritiesLendingType2Choice_
    #endif
    {
    }
}
