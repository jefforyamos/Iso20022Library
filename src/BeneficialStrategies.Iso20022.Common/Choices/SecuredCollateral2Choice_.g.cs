﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuredCollateral2Choice.  ISO2002 ID# _h6SUN6idEeWHO_l3hf2rlA.
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
    [KnownType(typeof(SecuredCollateral2Choice.SingleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.MultipleCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.PoolCollateral))]
    [KnownType(typeof(SecuredCollateral2Choice.OtherCollateral))]
    [IsoId("_h6SUN6idEeWHO_l3hf2rlA")]
    [DisplayName("Secured Collateral 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuredCollateral2Choice_
    #else
    public abstract partial class SecuredCollateral2Choice_
    #endif
    {
    }
}
