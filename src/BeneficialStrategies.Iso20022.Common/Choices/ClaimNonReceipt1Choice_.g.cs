﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClaimNonReceipt1Choice.  ISO2002 ID# _qFBVgIjYEeeDW7_wB-eK_g.
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
    /// Specifies whether the claim non receipt is accepted or rejected.
    /// </summary>
    [KnownType(typeof(ClaimNonReceipt1Choice.Accepted))]
    [KnownType(typeof(ClaimNonReceipt1Choice.Rejected))]
    [IsoId("_qFBVgIjYEeeDW7_wB-eK_g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Claim Non Receipt 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClaimNonReceipt1Choice_
    #else
    public abstract partial class ClaimNonReceipt1Choice_
    #endif
    {
    }
}
