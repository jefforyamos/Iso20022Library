﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReportingTransactionType3Choice.  ISO2002 ID# _6c12MZicEe2f7NHvXATP5g.
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
    /// Choice between a new or a cancellation transaction.
    /// </summary>
    [KnownType(typeof(ReportingTransactionType3Choice.New))]
    [KnownType(typeof(ReportingTransactionType3Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType3Choice.SupplementaryData))]
    [IsoId("_6c12MZicEe2f7NHvXATP5g")]
    [DisplayName("Reporting Transaction Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportingTransactionType3Choice_
    #else
    public abstract partial class ReportingTransactionType3Choice_
    #endif
    {
    }
}
