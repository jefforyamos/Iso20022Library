﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesUpdateReason1Choice.  ISO2002 ID# _20ciUJI7EeuAlLVx8pyt3w.
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
    /// Specifies the reason for the update of securities.
    /// </summary>
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Code))]
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Proprietary))]
    [IsoId("_20ciUJI7EeuAlLVx8pyt3w")]
    [DisplayName("Securities Update Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesUpdateReason1Choice_
    #else
    public abstract partial class SecuritiesUpdateReason1Choice_
    #endif
    {
    }
}
