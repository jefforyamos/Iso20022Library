﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairReason12Choice.  ISO2002 ID# _ja_PsTw5EeW3QqUkIQtIUA.
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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason12Choice.Code))]
    [KnownType(typeof(RepairReason12Choice.Proprietary))]
    [IsoId("_ja_PsTw5EeW3QqUkIQtIUA")]
    [DisplayName("Repair Reason 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairReason12Choice_
    #else
    public abstract partial class RepairReason12Choice_
    #endif
    {
    }
}
