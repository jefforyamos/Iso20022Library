﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SubBalanceQuantity1Choice.  ISO2002 ID# _QYn5aNp-Ed-ak6NoX_4Aeg_-1945125702.
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
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity1Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAsDSS))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAndAvailability))]
    [IsoId("_QYn5aNp-Ed-ak6NoX_4Aeg_-1945125702")]
    [DisplayName("Sub Balance Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity1Choice_
    #else
    public abstract partial class SubBalanceQuantity1Choice_
    #endif
    {
    }
}
