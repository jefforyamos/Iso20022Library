﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for BeneficiaryCertificationType10Choice.  ISO2002 ID# _dJFowUGUEeWqy4niLuXETA.
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
    /// Choice between a standard code or proprietary code to specify the type of beneficiary certification required.
    /// </summary>
    [KnownType(typeof(BeneficiaryCertificationType10Choice.Code))]
    [KnownType(typeof(BeneficiaryCertificationType10Choice.Proprietary))]
    [IsoId("_dJFowUGUEeWqy4niLuXETA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Beneficiary Certification Type 10 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficiaryCertificationType10Choice_
    #else
    public abstract partial class BeneficiaryCertificationType10Choice_
    #endif
    {
    }
}
