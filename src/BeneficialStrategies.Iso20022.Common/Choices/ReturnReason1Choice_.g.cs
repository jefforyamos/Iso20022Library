﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReturnReason1Choice.  ISO2002 ID# _TOkLx9p-Ed-ak6NoX_4Aeg_191375004.
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
    /// Reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason1Choice.Code))]
    [KnownType(typeof(ReturnReason1Choice.Proprietary))]
    [IsoId("_TOkLx9p-Ed-ak6NoX_4Aeg_191375004")]
    [DisplayName("Return Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReturnReason1Choice_
    #else
    public abstract partial class ReturnReason1Choice_
    #endif
    {
    }
}
