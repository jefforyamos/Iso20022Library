﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InsuranceType1Choice.  ISO2002 ID# _ckqDQBQZEeKebsB9eKJSkA.
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
    /// Choice of formats for the specification of the type of insurance.
    /// </summary>
    [KnownType(typeof(InsuranceType1Choice.Code))]
    [KnownType(typeof(InsuranceType1Choice.Proprietary))]
    [IsoId("_ckqDQBQZEeKebsB9eKJSkA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Insurance Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InsuranceType1Choice_
    #else
    public abstract partial class InsuranceType1Choice_
    #endif
    {
    }
}
