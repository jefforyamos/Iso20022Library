﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateType25Choice.  ISO2002 ID# _cbtx0YyeEeaxLOI-Kq-S4w.
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
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType25Choice.Addition))]
    [KnownType(typeof(UpdateType25Choice.Deletion))]
    [KnownType(typeof(UpdateType25Choice.Modification))]
    [IsoId("_cbtx0YyeEeaxLOI-Kq-S4w")]
    [DisplayName("Update Type 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType25Choice_
    #else
    public abstract partial class UpdateType25Choice_
    #endif
    {
    }
}
