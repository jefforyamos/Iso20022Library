﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionFeaturesFormat2Choice.  ISO2002 ID# _Q0L0Bdp-Ed-ak6NoX_4Aeg_-1816334318.
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
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat2Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat2Choice.Proprietary))]
    [IsoId("_Q0L0Bdp-Ed-ak6NoX_4Aeg_-1816334318")]
    [DisplayName("Option Features Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionFeaturesFormat2Choice_
    #else
    public abstract partial class OptionFeaturesFormat2Choice_
    #endif
    {
    }
}
