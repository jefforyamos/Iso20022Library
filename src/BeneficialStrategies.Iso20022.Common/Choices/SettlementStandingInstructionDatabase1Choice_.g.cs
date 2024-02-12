﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementStandingInstructionDatabase1Choice.  ISO2002 ID# _QtyRF9p-Ed-ak6NoX_4Aeg_-4724885.
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
    /// Choice of format for the standing settlement instruction information.
    /// </summary>
    [KnownType(typeof(SettlementStandingInstructionDatabase1Choice.Code))]
    [KnownType(typeof(SettlementStandingInstructionDatabase1Choice.Proprietary))]
    [IsoId("_QtyRF9p-Ed-ak6NoX_4Aeg_-4724885")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Standing Instruction Database 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStandingInstructionDatabase1Choice_
    #else
    public abstract partial class SettlementStandingInstructionDatabase1Choice_
    #endif
    {
    }
}
