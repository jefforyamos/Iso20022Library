﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ActiveOrHistoricAmountRange2Choice.  ISO2002 ID# _PHbQeZlcEeeE1Ya-LgRsuQ.
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
    /// Choice between a range of amount values with or without the currency.
    /// </summary>
    [KnownType(typeof(ActiveOrHistoricAmountRange2Choice.ImpliedCurrencyAndAmountRange))]
    [KnownType(typeof(ActiveOrHistoricAmountRange2Choice.CurrencyAndAmountRange))]
    [IsoId("_PHbQeZlcEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Active Or Historic Amount Range 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ActiveOrHistoricAmountRange2Choice_
    #else
    public abstract partial class ActiveOrHistoricAmountRange2Choice_
    #endif
    {
    }
}
