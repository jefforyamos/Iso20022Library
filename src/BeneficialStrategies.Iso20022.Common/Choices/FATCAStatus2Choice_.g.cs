﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FATCAStatus2Choice.  ISO2002 ID# _v4N-sSCVEeWJd9HF2tO7BA.
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
    /// Choice of formats for the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [KnownType(typeof(FATCAStatus2Choice.Code))]
    [KnownType(typeof(FATCAStatus2Choice.Proprietary))]
    [IsoId("_v4N-sSCVEeWJd9HF2tO7BA")]
    [DisplayName("FATCA Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FATCAStatus2Choice_
    #else
    public abstract partial class FATCAStatus2Choice_
    #endif
    {
    }
}
