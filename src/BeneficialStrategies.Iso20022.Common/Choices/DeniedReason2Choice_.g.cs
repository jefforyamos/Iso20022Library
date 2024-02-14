﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DeniedReason2Choice.  ISO2002 ID# _UW_MaNp-Ed-ak6NoX_4Aeg_1175171251.
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
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason2Choice.Code))]
    [KnownType(typeof(DeniedReason2Choice.Proprietary))]
    [IsoId("_UW_MaNp-Ed-ak6NoX_4Aeg_1175171251")]
    [DisplayName("Denied Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeniedReason2Choice_
    #else
    public abstract partial class DeniedReason2Choice_
    #endif
    {
    }
}
