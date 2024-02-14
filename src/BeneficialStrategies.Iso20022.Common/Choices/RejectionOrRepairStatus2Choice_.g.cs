﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionOrRepairStatus2Choice.  ISO2002 ID# _UW1bZdp-Ed-ak6NoX_4Aeg_1986298919.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus2Choice.Reason))]
    [IsoId("_UW1bZdp-Ed-ak6NoX_4Aeg_1986298919")]
    [DisplayName("Rejection Or Repair Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionOrRepairStatus2Choice_
    #else
    public abstract partial class RejectionOrRepairStatus2Choice_
    #endif
    {
    }
}
