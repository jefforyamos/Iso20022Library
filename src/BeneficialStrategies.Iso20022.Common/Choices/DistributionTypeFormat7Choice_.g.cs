﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DistributionTypeFormat7Choice.  ISO2002 ID# _4kYtQUEFEeWVgfuHGaKtRQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat7Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat7Choice.Proprietary))]
    [IsoId("_4kYtQUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Distribution Type Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionTypeFormat7Choice_
    #else
    public abstract partial class DistributionTypeFormat7Choice_
    #endif
    {
    }
}
