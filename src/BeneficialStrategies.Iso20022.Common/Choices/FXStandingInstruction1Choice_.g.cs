﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FXStandingInstruction1Choice.  ISO2002 ID# _QuFMBdp-Ed-ak6NoX_4Aeg_-1270541396.
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
    /// Choice of format for the FX Standing Instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction1Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction1Choice.Proprietary))]
    [IsoId("_QuFMBdp-Ed-ak6NoX_4Aeg_-1270541396")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("FX Standing Instruction 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXStandingInstruction1Choice_
    #else
    public abstract partial class FXStandingInstruction1Choice_
    #endif
    {
    }
}
