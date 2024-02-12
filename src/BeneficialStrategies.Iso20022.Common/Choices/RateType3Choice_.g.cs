﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateType3Choice.  ISO2002 ID# _RBJ5B9p-Ed-ak6NoX_4Aeg_811184279.
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
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType3Choice.Code))]
    [KnownType(typeof(RateType3Choice.Proprietary))]
    [IsoId("_RBJ5B9p-Ed-ak6NoX_4Aeg_811184279")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Type 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType3Choice_
    #else
    public abstract partial class RateType3Choice_
    #endif
    {
    }
}
