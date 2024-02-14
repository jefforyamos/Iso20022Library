﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TimeFrame5Choice.  ISO2002 ID# _UAew7Np-Ed-ak6NoX_4Aeg_1119548920.
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
    /// Choice between TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame5Choice.TradePlus))]
    [KnownType(typeof(TimeFrame5Choice.Prepayment))]
    [IsoId("_UAew7Np-Ed-ak6NoX_4Aeg_1119548920")]
    [DisplayName("Time Frame 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame5Choice_
    #else
    public abstract partial class TimeFrame5Choice_
    #endif
    {
    }
}
