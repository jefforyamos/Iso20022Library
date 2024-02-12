﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProfitAndLoss1Choice.  ISO2002 ID# _Q65gCNp-Ed-ak6NoX_4Aeg_-931034423.
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
    [KnownType(typeof(ProfitAndLoss1Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss1Choice.Loss))]
    [IsoId("_Q65gCNp-Ed-ak6NoX_4Aeg_-931034423")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Profit And Loss 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProfitAndLoss1Choice_
    #else
    public abstract partial class ProfitAndLoss1Choice_
    #endif
    {
    }
}
