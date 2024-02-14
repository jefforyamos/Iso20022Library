﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for QuantityNominalValue1Choice.  ISO2002 ID# _kXBi4HaiEeavseMKyTsJEA.
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
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [KnownType(typeof(QuantityNominalValue1Choice.Quantity))]
    [KnownType(typeof(QuantityNominalValue1Choice.NominalValue))]
    [IsoId("_kXBi4HaiEeavseMKyTsJEA")]
    [DisplayName("Quantity Nominal Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityNominalValue1Choice_
    #else
    public abstract partial class QuantityNominalValue1Choice_
    #endif
    {
    }
}
