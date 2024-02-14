﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateOrName2Choice.  ISO2002 ID# _XO3Ydtp-Ed-ak6NoX_4Aeg_-1773453138.
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
    /// Choice between a percentage rate or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName2Choice.Rate))]
    [KnownType(typeof(RateOrName2Choice.RateName))]
    [IsoId("_XO3Ydtp-Ed-ak6NoX_4Aeg_-1773453138")]
    [DisplayName("Rate Or Name 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrName2Choice_
    #else
    public abstract partial class RateOrName2Choice_
    #endif
    {
    }
}
