﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuredCollateral1Choice.  ISO2002 ID# _wmCdQJf5EeSfnc-VXAEapg.
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
    /// Provides the collateral details for the secured markets.
    /// </summary>
    [KnownType(typeof(SecuredCollateral1Choice.SingleCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.MultipleCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.PoolCollateral))]
    [KnownType(typeof(SecuredCollateral1Choice.OtherCollateral))]
    [IsoId("_wmCdQJf5EeSfnc-VXAEapg")]
    [DisplayName("Secured Collateral 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuredCollateral1Choice_
    #else
    public abstract partial class SecuredCollateral1Choice_
    #endif
    {
    }
}
