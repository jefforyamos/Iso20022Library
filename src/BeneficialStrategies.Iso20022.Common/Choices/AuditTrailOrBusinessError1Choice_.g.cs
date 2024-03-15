﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AuditTrailOrBusinessError1Choice.  ISO2002 ID# _kzKJFO5NEeCisYr99QEiWA_1431906360.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Report between the static data audit trail or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError1Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError1Choice.BusinessError))]
    [IsoId("_kzKJFO5NEeCisYr99QEiWA_1431906360")]
    [DisplayName("Audit Trail Or Business Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AuditTrailOrBusinessError1Choice_
    #else
    public abstract partial class AuditTrailOrBusinessError1Choice_
    #endif
    {
    }
}
