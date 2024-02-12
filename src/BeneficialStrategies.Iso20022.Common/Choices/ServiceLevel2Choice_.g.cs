﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ServiceLevel2Choice.  ISO2002 ID# _QJkwwdp-Ed-ak6NoX_4Aeg_913208063.
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
    /// Specifies the service level of the transaction.
    /// </summary>
    [KnownType(typeof(ServiceLevel2Choice.Code))]
    [KnownType(typeof(ServiceLevel2Choice.Proprietary))]
    [IsoId("_QJkwwdp-Ed-ak6NoX_4Aeg_913208063")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Level 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ServiceLevel2Choice_
    #else
    public abstract partial class ServiceLevel2Choice_
    #endif
    {
    }
}
