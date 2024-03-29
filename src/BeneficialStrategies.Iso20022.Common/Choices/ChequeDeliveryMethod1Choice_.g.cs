﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChequeDeliveryMethod1Choice.  ISO2002 ID# _QbwF5tp-Ed-ak6NoX_4Aeg_258234806.
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
    /// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
    /// </summary>
    [KnownType(typeof(ChequeDeliveryMethod1Choice.Code))]
    [KnownType(typeof(ChequeDeliveryMethod1Choice.Proprietary))]
    [IsoId("_QbwF5tp-Ed-ak6NoX_4Aeg_258234806")]
    [DisplayName("Cheque Delivery Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChequeDeliveryMethod1Choice_
    #else
    public abstract partial class ChequeDeliveryMethod1Choice_
    #endif
    {
    }
}
