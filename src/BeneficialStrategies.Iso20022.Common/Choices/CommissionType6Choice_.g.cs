﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CommissionType6Choice.  ISO2002 ID# _SU7-gZBhEeakHoV5BVecAQ.
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
    /// Choice between a code or a data source scheme to determine the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType6Choice.Code))]
    [KnownType(typeof(CommissionType6Choice.Proprietary))]
    [IsoId("_SU7-gZBhEeakHoV5BVecAQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commission Type 6 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommissionType6Choice_
    #else
    public abstract partial class CommissionType6Choice_
    #endif
    {
    }
}
