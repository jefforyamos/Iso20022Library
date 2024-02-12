﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProxyAccountType1Choice.  ISO2002 ID# _dyock3h3EeidzqjNEfehPg.
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
    /// Specifies the scheme used for the identification of an account alias.
    /// </summary>
    [KnownType(typeof(ProxyAccountType1Choice.Code))]
    [KnownType(typeof(ProxyAccountType1Choice.Proprietary))]
    [IsoId("_dyock3h3EeidzqjNEfehPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proxy Account Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProxyAccountType1Choice_
    #else
    public abstract partial class ProxyAccountType1Choice_
    #endif
    {
    }
}
