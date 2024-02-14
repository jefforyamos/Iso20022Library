﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OptionStyle9Choice.  ISO2002 ID# _ctPX95KQEeWHWpTQn1FFVg.
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
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle9Choice.Code))]
    [KnownType(typeof(OptionStyle9Choice.Proprietary))]
    [IsoId("_ctPX95KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Style 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionStyle9Choice_
    #else
    public abstract partial class OptionStyle9Choice_
    #endif
    {
    }
}
