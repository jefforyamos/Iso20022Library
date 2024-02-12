﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepoCallRequestStatus5Choice.  ISO2002 ID# _fHQhMf7rEeCvPoRGOxRobQ.
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
    [KnownType(typeof(RepoCallRequestStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus5Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus5Choice.Proprietary))]
    [IsoId("_fHQhMf7rEeCvPoRGOxRobQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repo Call Request Status 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus5Choice_
    #else
    public abstract partial class RepoCallRequestStatus5Choice_
    #endif
    {
    }
}
