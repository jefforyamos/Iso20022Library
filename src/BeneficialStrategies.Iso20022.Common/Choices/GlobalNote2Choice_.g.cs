﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GlobalNote2Choice.  ISO2002 ID# _TiBdgeLaEeWFtOV72FbX9w.
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
    /// Choice of format for global note.
    /// </summary>
    [KnownType(typeof(GlobalNote2Choice.Code))]
    [KnownType(typeof(GlobalNote2Choice.Proprietary))]
    [IsoId("_TiBdgeLaEeWFtOV72FbX9w")]
    [DisplayName("Global Note 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GlobalNote2Choice_
    #else
    public abstract partial class GlobalNote2Choice_
    #endif
    {
    }
}
