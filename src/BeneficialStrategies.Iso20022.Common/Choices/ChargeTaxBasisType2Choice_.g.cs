﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeTaxBasisType2Choice.  ISO2002 ID# _VKcMAZBhEeakHoV5BVecAQ.
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
    /// Choice of format for the charge tax basis.
    /// </summary>
    [KnownType(typeof(ChargeTaxBasisType2Choice.Code))]
    [KnownType(typeof(ChargeTaxBasisType2Choice.Proprietary))]
    [IsoId("_VKcMAZBhEeakHoV5BVecAQ")]
    [DisplayName("Charge Tax Basis Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTaxBasisType2Choice_
    #else
    public abstract partial class ChargeTaxBasisType2Choice_
    #endif
    {
    }
}
