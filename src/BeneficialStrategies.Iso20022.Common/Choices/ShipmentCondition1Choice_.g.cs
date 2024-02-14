﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ShipmentCondition1Choice.  ISO2002 ID# _TISQMLGdEeuSTr8k0UEM8A.
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
    /// Choice of format for the shipment conditions.
    /// </summary>
    [KnownType(typeof(ShipmentCondition1Choice.Code))]
    [KnownType(typeof(ShipmentCondition1Choice.Proprietary))]
    [IsoId("_TISQMLGdEeuSTr8k0UEM8A")]
    [DisplayName("Shipment Condition 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ShipmentCondition1Choice_
    #else
    public abstract partial class ShipmentCondition1Choice_
    #endif
    {
    }
}
