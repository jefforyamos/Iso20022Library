﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IntermediateSecuritiesDistributionTypeFormat2Choice.  ISO2002 ID# _Q0L0Atp-Ed-ak6NoX_4Aeg_-965201377.
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
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Proprietary))]
    [IsoId("_Q0L0Atp-Ed-ak6NoX_4Aeg_-965201377")]
    [DisplayName("Intermediate Securities Distribution Type Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat2Choice_
    #else
    public abstract partial class IntermediateSecuritiesDistributionTypeFormat2Choice_
    #endif
    {
    }
}
