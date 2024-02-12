﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateType33Choice.  ISO2002 ID# _lg1sUQleEeuQ1MenzX1l-g.
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
    [KnownType(typeof(UpdateType33Choice.Addition))]
    [KnownType(typeof(UpdateType33Choice.Deletion))]
    [KnownType(typeof(UpdateType33Choice.Modification))]
    [IsoId("_lg1sUQleEeuQ1MenzX1l-g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Update Type 33 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType33Choice_
    #else
    public abstract partial class UpdateType33Choice_
    #endif
    {
    }
}
