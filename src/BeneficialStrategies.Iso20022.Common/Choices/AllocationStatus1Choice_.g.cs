﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AllocationStatus1Choice.  ISO2002 ID# _D01G0N_-EeiVRbNQx5-Vhg.
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
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [KnownType(typeof(AllocationStatus1Choice.FullyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.PartiallyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.Proprietary))]
    [IsoId("_D01G0N_-EeiVRbNQx5-Vhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Allocation Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllocationStatus1Choice_
    #else
    public abstract partial class AllocationStatus1Choice_
    #endif
    {
    }
}
