﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SubBalanceType11Choice.  ISO2002 ID# _kRCJATnXEeWV5sr121Fc8A.
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
    /// Choice of format for the sub-balance.
    /// </summary>
    [KnownType(typeof(SubBalanceType11Choice.Code))]
    [KnownType(typeof(SubBalanceType11Choice.Proprietary))]
    [IsoId("_kRCJATnXEeWV5sr121Fc8A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Balance Type 11 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceType11Choice_
    #else
    public abstract partial class SubBalanceType11Choice_
    #endif
    {
    }
}
