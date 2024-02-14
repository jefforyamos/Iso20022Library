﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RatioFormat12Choice.  ISO2002 ID# _g3oegOwOEd-sn-FiNtktcA.
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
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat12Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat12Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat12Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.QuantityToAmount))]
    [IsoId("_g3oegOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat12Choice_
    #else
    public abstract partial class RatioFormat12Choice_
    #endif
    {
    }
}
