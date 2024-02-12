﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationRejectionStatus1Choice.  ISO2002 ID# _RCfVyNp-Ed-ak6NoX_4Aeg_1555805639.
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
    /// Choice of cancellation rejection status.
    /// </summary>
    [KnownType(typeof(CancellationRejectionStatus1Choice.Code))]
    [KnownType(typeof(CancellationRejectionStatus1Choice.Proprietary))]
    [IsoId("_RCfVyNp-Ed-ak6NoX_4Aeg_1555805639")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation Rejection Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationRejectionStatus1Choice_
    #else
    public abstract partial class CancellationRejectionStatus1Choice_
    #endif
    {
    }
}
