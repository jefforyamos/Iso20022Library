﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus43Choice.  ISO2002 ID# _ezCkoVhFEeOMYfRGLS0NbA.
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
    /// Choice of formats for the specification of a status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus43Choice.Received))]
    [KnownType(typeof(ProcessingStatus43Choice.Accepted))]
    [KnownType(typeof(ProcessingStatus43Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus43Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus43Choice.ProprietaryStatus))]
    [IsoId("_ezCkoVhFEeOMYfRGLS0NbA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status 43 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus43Choice_
    #else
    public abstract partial class ProcessingStatus43Choice_
    #endif
    {
    }
}
