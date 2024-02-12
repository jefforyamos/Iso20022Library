﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CategoryPurpose1Choice.  ISO2002 ID# _THaa5Np-Ed-ak6NoX_4Aeg_1223014142.
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
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(CategoryPurpose1Choice.Code))]
    [KnownType(typeof(CategoryPurpose1Choice.Proprietary))]
    [IsoId("_THaa5Np-Ed-ak6NoX_4Aeg_1223014142")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Category Purpose 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CategoryPurpose1Choice_
    #else
    public abstract partial class CategoryPurpose1Choice_
    #endif
    {
    }
}
