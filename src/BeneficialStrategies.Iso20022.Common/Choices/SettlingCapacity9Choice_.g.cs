﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlingCapacity9Choice.  ISO2002 ID# _hOSOwZEZEeakHoV5BVecAQ.
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
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity9Choice.Code))]
    [KnownType(typeof(SettlingCapacity9Choice.Proprietary))]
    [IsoId("_hOSOwZEZEeakHoV5BVecAQ")]
    [DisplayName("Settling Capacity 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlingCapacity9Choice_
    #else
    public abstract partial class SettlingCapacity9Choice_
    #endif
    {
    }
}
