﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PensionTransferScope1Choice.  ISO2002 ID# _REBa0E4YEeiQHa-q1Uephw.
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
    /// Choice of formats for the scope of a pension transfer.
    /// </summary>
    [KnownType(typeof(PensionTransferScope1Choice.Code))]
    [KnownType(typeof(PensionTransferScope1Choice.Proprietary))]
    [IsoId("_REBa0E4YEeiQHa-q1Uephw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pension Transfer Scope 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PensionTransferScope1Choice_
    #else
    public abstract partial class PensionTransferScope1Choice_
    #endif
    {
    }
}
