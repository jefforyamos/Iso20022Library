﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CommissionBasis1Choice.  ISO2002 ID# _LgZzgRuCEeOqSdXzJ0oydA.
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
    /// Choice of formats for the commission basis.
    /// </summary>
    [KnownType(typeof(CommissionBasis1Choice.Code))]
    [KnownType(typeof(CommissionBasis1Choice.Proprietary))]
    [IsoId("_LgZzgRuCEeOqSdXzJ0oydA")]
    [DisplayName("Commission Basis 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommissionBasis1Choice_
    #else
    public abstract partial class CommissionBasis1Choice_
    #endif
    {
    }
}
