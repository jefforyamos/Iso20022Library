﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Product1Choice.  ISO2002 ID# _AS4VYLVPEeadLcJesEbkTQ.
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
    /// Specifies the choice between the major categories of financial instruments.
    /// </summary>
    [KnownType(typeof(Product1Choice.Derivative))]
    [KnownType(typeof(Product1Choice.SecuritiesFinancingTransaction))]
    [KnownType(typeof(Product1Choice.Security))]
    [IsoId("_AS4VYLVPEeadLcJesEbkTQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Product1Choice_
    #else
    public abstract partial class Product1Choice_
    #endif
    {
    }
}
