﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FXAmountType1Choice.  ISO2002 ID# _Z-9lgwN2Ee2-vqzwMUAewg.
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
    /// Choice of different FX amount types.
    /// </summary>
    [KnownType(typeof(FXAmountType1Choice.Code))]
    [KnownType(typeof(FXAmountType1Choice.Proprietary))]
    [IsoId("_Z-9lgwN2Ee2-vqzwMUAewg")]
    [DisplayName("FX Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXAmountType1Choice_
    #else
    public abstract partial class FXAmountType1Choice_
    #endif
    {
    }
}
