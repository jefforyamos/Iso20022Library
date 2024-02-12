﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DistributionPolicy2Choice.  ISO2002 ID# _HolxYeLaEeWFtOV72FbX9w.
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
    /// Choice of format for a distribution policy.
    /// </summary>
    [KnownType(typeof(DistributionPolicy2Choice.Code))]
    [KnownType(typeof(DistributionPolicy2Choice.Proprietary))]
    [IsoId("_HolxYeLaEeWFtOV72FbX9w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Distribution Policy 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionPolicy2Choice_
    #else
    public abstract partial class DistributionPolicy2Choice_
    #endif
    {
    }
}
