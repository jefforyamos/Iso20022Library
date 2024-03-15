﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepoCallRequestStatus7Choice.  ISO2002 ID# _3eDsYTp4EeWVrPy0StzzSg.
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
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Proprietary))]
    [IsoId("_3eDsYTp4EeWVrPy0StzzSg")]
    [DisplayName("Repo Call Request Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus7Choice_
    #else
    public abstract partial class RepoCallRequestStatus7Choice_
    #endif
    {
    }
}
