﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceFormat63Choice.  ISO2002 ID# _Rt7u8Q-zEeuE0Pnt-OcNOA.
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
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat63Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat63Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat63Choice.NotSpecifiedPrice))]
    [IsoId("_Rt7u8Q-zEeuE0Pnt-OcNOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Format 63 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat63Choice_
    #else
    public abstract partial class PriceFormat63Choice_
    #endif
    {
    }
}
