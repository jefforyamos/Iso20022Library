﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DisputeResolutionType1Choice.  ISO2002 ID# _QmogNdp-Ed-ak6NoX_4Aeg_1282948020.
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
    /// Choice between a code or a proprietary code as to the nature of the dispute about the collateral amount.
    /// </summary>
    [KnownType(typeof(DisputeResolutionType1Choice.Code))]
    [KnownType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification))]
    [IsoId("_QmogNdp-Ed-ak6NoX_4Aeg_1282948020")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Resolution Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisputeResolutionType1Choice_
    #else
    public abstract partial class DisputeResolutionType1Choice_
    #endif
    {
    }
}
