﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProfitAndLoss2Choice.  ISO2002 ID# _NDhRoWYDEeaJx-BUPcSWQA.
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
    /// Choice between profit and loss.
    /// </summary>
    [KnownType(typeof(ProfitAndLoss2Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss2Choice.Loss))]
    [IsoId("_NDhRoWYDEeaJx-BUPcSWQA")]
    [DisplayName("Profit And Loss 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProfitAndLoss2Choice_
    #else
    public abstract partial class ProfitAndLoss2Choice_
    #endif
    {
    }
}
