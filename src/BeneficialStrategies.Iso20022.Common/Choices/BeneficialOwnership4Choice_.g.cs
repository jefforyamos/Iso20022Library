﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BeneficialOwnership4Choice.  ISO2002 ID# _TaICwTqGEeWVrPy0StzzSg.
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
    /// Choice of format for the beneficial ownership.
    /// </summary>
    [KnownType(typeof(BeneficialOwnership4Choice.Indicator))]
    [KnownType(typeof(BeneficialOwnership4Choice.Proprietary))]
    [IsoId("_TaICwTqGEeWVrPy0StzzSg")]
    [DisplayName("Beneficial Ownership 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficialOwnership4Choice_
    #else
    public abstract partial class BeneficialOwnership4Choice_
    #endif
    {
    }
}
