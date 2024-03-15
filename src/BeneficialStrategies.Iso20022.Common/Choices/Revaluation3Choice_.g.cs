﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Revaluation3Choice.  ISO2002 ID# _sfc1cZEjEeakHoV5BVecAQ.
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
    /// Choice between an indicator or a data source scheme to determine the revaluation.
    /// </summary>
    [KnownType(typeof(Revaluation3Choice.Indicator))]
    [KnownType(typeof(Revaluation3Choice.Proprietary))]
    [IsoId("_sfc1cZEjEeakHoV5BVecAQ")]
    [DisplayName("Revaluation 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Revaluation3Choice_
    #else
    public abstract partial class Revaluation3Choice_
    #endif
    {
    }
}
