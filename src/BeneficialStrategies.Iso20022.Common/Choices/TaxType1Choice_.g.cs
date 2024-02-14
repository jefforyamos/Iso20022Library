﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxType1Choice.  ISO2002 ID# _qVh7URuHEeOqSdXzJ0oydA.
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
    /// Choice of formats for the type of tax.
    /// </summary>
    [KnownType(typeof(TaxType1Choice.Code))]
    [KnownType(typeof(TaxType1Choice.Proprietary))]
    [IsoId("_qVh7URuHEeOqSdXzJ0oydA")]
    [DisplayName("Tax Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxType1Choice_
    #else
    public abstract partial class TaxType1Choice_
    #endif
    {
    }
}
