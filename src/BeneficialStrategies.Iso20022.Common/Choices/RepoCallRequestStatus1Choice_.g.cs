﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepoCallRequestStatus1Choice.  ISO2002 ID# _UXIWVdp-Ed-ak6NoX_4Aeg_-695454227.
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
    [KnownType(typeof(RepoCallRequestStatus1Choice.Code))]
    [KnownType(typeof(RepoCallRequestStatus1Choice.Proprietary))]
    [IsoId("_UXIWVdp-Ed-ak6NoX_4Aeg_-695454227")]
    [DisplayName("Repo Call Request Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus1Choice_
    #else
    public abstract partial class RepoCallRequestStatus1Choice_
    #endif
    {
    }
}
