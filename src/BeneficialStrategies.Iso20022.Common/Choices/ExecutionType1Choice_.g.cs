﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExecutionType1Choice.  ISO2002 ID# _75qQhqMgEeCJ6YNENx4h-w_354040007.
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
    /// Defines the type of execution to be performed in the request.
    /// </summary>
    [KnownType(typeof(ExecutionType1Choice.Time))]
    [KnownType(typeof(ExecutionType1Choice.Event))]
    [IsoId("_75qQhqMgEeCJ6YNENx4h-w_354040007")]
    [DisplayName("Execution Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExecutionType1Choice_
    #else
    public abstract partial class ExecutionType1Choice_
    #endif
    {
    }
}
